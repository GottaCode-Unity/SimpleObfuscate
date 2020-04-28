using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleObfuscate
{
    public partial class MainWindow : Form
    {
        private string savePath = Environment.CurrentDirectory;

        private string inputClassesPath;

        private string outputClassesPath;

        public MainWindow()
        {
            inputClassesPath = savePath + @"\inputClasses";

            outputClassesPath = savePath + @"\outputClasses";

            SetupFileStorage();

            InitializeComponent();

            UpdateInputClasses();
        }

        private void SetupFileStorage()
        {
            if (!Directory.Exists(inputClassesPath))
            {
                Directory.CreateDirectory(inputClassesPath);
            }

            if (Directory.Exists(outputClassesPath))
            {
                foreach (string item in Directory.GetFiles(outputClassesPath))
                {
                    File.Delete(item);
                }
            }
            else
            {
                Directory.CreateDirectory(outputClassesPath);
            }
        }

        private void UpdateInputClasses()
        {
            lbInputClasses.Items.Clear();

            lbKeywords.Items.Clear();

            files.Clear();

            DirSearch(inputClassesPath);

            foreach (string path in files)
            {
                string className = path.Split('\\').Last();

                if (className.Split('.')[1] == tbEnding.Text)
                {
                    lbInputClasses.Items.Add(className);

                    lbKeywords.Items.Add(className.Split('.')[0]);
                }
            }
        }

        List<string> files = new List<string>();

        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            if (File.Exists(ofd.FileName))
            {
                if (File.Exists(inputClassesPath + $@"\{ofd.SafeFileName}"))
                {
                    MessageBox.Show("Error", "This class is already imported!");
                }

                File.Copy(ofd.FileName, inputClassesPath + $@"\{ofd.SafeFileName}");

                UpdateInputClasses();
            }
        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            foreach (var path in files)
            {
                string className = path.Split('\\').Last();

                if (className == lbInputClasses.Items[lbInputClasses.SelectedIndex].ToString())
                {
                    string[] pathh = path.Split('\\');

                    string newPath = "";

                    for (int g = 0; g < pathh.Length - 1; g++)
                    {
                        newPath += pathh[g] + "\\";
                    }

                    if (!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }

                    path.Replace("inputClasses", "outputClasses");

                    File.Delete(path/*outputClassesPath + $@"\{obfuscatedKeywords[x]}.{classes[x].Split('.')[1]}"*/);

                    break;
                }
            }

            UpdateInputClasses();
        }

        private void lbInputClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInputClasses.SelectedIndex < 0)
            {
                return;
            }

            foreach (var path in files)
            {
                string className = lbInputClasses.SelectedItem.ToString();

                if (path.Split('\\').Last() == className)
                {
                    tbClassPreview.Text = File.ReadAllText(path/*outputClassesPath + $@"\{obfuscatedKeywords[x]}.{classes[x].Split('.')[1]}"*/);

                    //List<string> temp = WriteList(tbClassPreview.Text, new string[] { "String" , "Integer" , "var" , "int" , "boolean" , "void" , "String[]" , "Integer[]" });

                    //foreach (var item in temp)
                    //{
                        //if (!lbKeywords.Items.Contains(item))
                        //{
                           // lbKeywords.Items.Add(item);
                        //}
                    //}

                    break;
                }
            }
        }

        private void btnNewKeyword_Click(object sender, EventArgs e)
        {
            if (!tbKeyword.Text.Contains(" ") && !tbKeyword.Text.Contains(".") && tbKeyword.Text != "")
            {
                if (lbKeywords.Items.Contains(tbKeyword.Text))
                {
                    MessageBox.Show("Keyword is already selected!", "Simple Obfuscate");

                    return;
                }

                lbKeywords.Items.Add(tbKeyword.Text);

                tbKeyword.Text = "";
            }
        }

        private void btnRemoveKeyword_Click(object sender, EventArgs e)
        {
            if (lbKeywords.SelectedIndex >= 0)
            {
                lbKeywords.Items.RemoveAt(lbKeywords.SelectedIndex);
            }
        }

        private void btnViewPutput_Click(object sender, EventArgs e)
        {
            Process.Start(outputClassesPath);
        }

        private void btnStartObfuscator_Click(object sender, EventArgs e)
        {
            Status status = new Status();

            status.SetMaxPB(lbInputClasses.Items.Count);

            status.Show();

            status.SetDoing("Getting keywords...");

            status.Update();

            string[] temp = new string[lbKeywords.Items.Count];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = lbKeywords.Items[i].ToString();
            }

            if (Directory.Exists(outputClassesPath))
            {
                Directory.Delete(outputClassesPath, true);
            }

            Directory.CreateDirectory(outputClassesPath);


            btnStartObfuscator.Enabled = false;

            Args args = new Args();

            args.status = status;

            args.keywords = temp;

            Thread Obfs = new Thread(Obfuscate);

            Obfs.Start(args);
        }

        public void ObfuscateClass(Object obj)
        {
            ThreadArgs args = (ThreadArgs)obj;

            string currentClass = args.classes[args.i].Split('.')[0];

            foreach (var path in files)
            {
                string className = path.Split('\\').Last();

                if (className == args.classes[args.i])
                {
                    string[] pathh = path.Split('\\');

                    string newPath = "";

                    for (int g = 0; g < pathh.Length - 1; g++)
                    {
                        newPath += pathh[g] + "\\";
                    }

                    args.obfuscatedClass = File.ReadAllText(path);

                    break;
                }
            }

            bool bracket = false;

            for (int j = 0; j < args.keywords.Length; j++)
            {
                for (int f = 0; f < args.obfuscatedClass.Length; f++)
                {
                    if (args.obfuscatedClass[f] == '"')
                    {
                        bracket = !bracket;
                    }

                    try
                    {
                        if (!bracket)
                            if (args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + " " || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + ";" || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "(" || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "=" || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "." || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + ">" || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "\n" || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "\r" || args.obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "\t")
                            {
                                args.obfuscatedClass = args.obfuscatedClass.Substring(0, f) + args.obfuscatedKeywords[j] + args.obfuscatedClass.Substring(f + args.keywords[j].Length);
                            }
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            for (int x = 0; x < args.keywords.Length; x++)
            {
                try
                {
                    if (currentClass == args.keywords[x])
                    {
                        foreach (var path in files)
                        {
                            string className = path.Split('\\').Last();

                            if (className == args.classes[x])
                            {
                                string[] pathh = path.Split('\\');

                                string newPath = "";

                                string savePath = "";

                                for (int g = 0; g < pathh.Length - 1; g++)
                                {
                                    if (pathh[g] == "inputClasses")
                                    {
                                        newPath += "outputClasses" + "\\";
                                    }
                                    else
                                    {
                                        newPath += pathh[g] + "\\";
                                    }

                                    if (pathh[g] == "inputClasses")
                                    {
                                        savePath += "outputClasses" + "\\";
                                    }
                                    else if (pathh[g].Contains("." + tbEnding.Text))
                                    {
                                        savePath += args.obfuscatedKeywords[x] + "." + tbEnding.Text;
                                    }
                                    else
                                    {
                                        savePath += pathh[g] + "\\";
                                    }
                                }

                                savePath += args.obfuscatedKeywords[x] + "." + tbEnding.Text;

                                if (!Directory.Exists(newPath))
                                {
                                    Directory.CreateDirectory(newPath);
                                }

                                File.WriteAllText(savePath/*outputClassesPath + $@"\{obfuscatedKeywords[x]}.{classes[x].Split('.')[1]}"*/, args.obfuscatedClass);

                                break;
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }

            args.status.addStepPB();
        }

        private void Obfuscate(Object obj)
        {
            Args args = (Args)obj;

            try
            {
                string[] classes = new string[lbInputClasses.Items.Count];

                for (int i = 0; i < classes.Length; i++)
                {
                    classes[i] = lbInputClasses.Items[i].ToString();
                }

                Random rnd = new Random();

                string[] obfuscatedKeywords = new string[args.keywords.Length];

                for (int i = 0; i < obfuscatedKeywords.Length; i++)
                {
                    string temp = "";

                    for (int j = 0; j < nudNameCount.Value; j++)
                    {
                        if (rnd.Next(0, 2) == 0)
                        {
                            temp += "I";
                        }
                        else
                        {
                            temp += "l";
                        }
                    }

                    if (obfuscatedKeywords.Contains(temp))
                    {
                        i--;
                    }
                    else
                    {
                        obfuscatedKeywords[i] = temp;
                    }
                }

                string mapping = "";

                for (int k = 0; k < args.keywords.Length; k++)
                {
                    mapping += args.keywords[k] + " -> " + obfuscatedKeywords[k] + '\n';
                }

                File.WriteAllText(outputClassesPath + @"\mapping.txt", mapping);

                args.status.addStepPB();

                if (tbTurboMode.Checked)
                {
                    args.status.SetDoing("Starting threads...");

                    args.status.SetMaxPB(classes.Length);

                    for (int u = 0; u < classes.Length; u++)
                    {
                        ThreadArgs argss = new ThreadArgs();

                        argss.classes = classes;

                        argss.status = args.status;

                        argss.i = u;

                        argss.keywords = args.keywords;

                        string obfuscatedClass = "";

                        foreach (var path in files)
                        {
                            string className = path.Split('\\').Last();

                            if (className == classes[u])
                            {
                                string[] pathh = path.Split('\\');

                                string newPath = "";

                                for (int g = 0; g < pathh.Length - 1; g++)
                                {
                                    newPath += pathh[g] + "\\";
                                }

                                obfuscatedClass = File.ReadAllText(path);

                                break;
                            }
                        }

                        argss.obfuscatedClass = obfuscatedClass;

                        argss.obfuscatedKeywords = obfuscatedKeywords;

                        Thread newClassThread = new Thread(ObfuscateClass);

                        newClassThread.Start(argss);
                    }

                    args.status.addStepPB();

                    args.status.SetDoing("Started all threads!");

                    btnStartObfuscator.Enabled = true;

                    return;
                }

                for (int i = 0; i < classes.Length; i++)
                {
                    args.status.SetDoing($"Obfuscating class {classes[i]}...");

                    string currentClass = classes[i].Split('.')[0];

                    string obfuscatedClass = "";

                    foreach (var path in files)
                    {
                        string className = path.Split('\\').Last();

                        if (className == classes[i])
                        {
                            string[] pathh = path.Split('\\');

                            string newPath = "";

                            for (int g = 0; g < pathh.Length - 1; g++)
                            {
                                newPath += pathh[g] + "\\";
                            }

                            obfuscatedClass = File.ReadAllText(path);

                            break;
                        }
                    }

                    bool bracket = false;

                    args.status.SetMaxPBKeywords(args.keywords.Length);

                    args.status.addStepPBKeywords();

                    for (int j = 0; j < args.keywords.Length; j++)
                    {
                        args.status.SetDoingKeywords($"Replacing {args.keywords[j]}...");

                        args.status.SetMaxPBClass(obfuscatedClass.Length);

                        for (int f = 0; f < obfuscatedClass.Length; f++)
                        {
                            args.status.SetDoingClass($"Process {f}/{obfuscatedClass.Length}");

                            if (obfuscatedClass[f] == '"')
                            {
                                bracket = !bracket;
                            }

                            try
                            {
                                if (!bracket)
                                    if (obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + " " || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + ";" || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "(" || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "=" || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "." || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + ">" || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "\n" || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "\r" || obfuscatedClass.Substring(f, args.keywords[j].Length + 1) == args.keywords[j] + "\t")
                                    {
                                        obfuscatedClass = obfuscatedClass.Substring(0, f) + obfuscatedKeywords[j] + obfuscatedClass.Substring(f + args.keywords[j].Length);
                                    }
                            }
                            catch (Exception)
                            {

                            }

                            args.status.addStepPBClass();
                        }

                        args.status.addStepPBKeywords();
                    }

                    for (int x = 0; x < args.keywords.Length; x++)
                    {
                        try
                        {
                            if (currentClass == args.keywords[x])
                            {
                                foreach (var path in files)
                                {
                                    string className = path.Split('\\').Last();

                                    if (className == classes[x])
                                    {
                                        string[] pathh = path.Split('\\');

                                        string newPath = "";

                                        string savePath = "";

                                        for (int g = 0; g < pathh.Length - 1; g++)
                                        {
                                            if (pathh[g] == "inputClasses")
                                            {
                                                newPath += "outputClasses" + "\\";
                                            }
                                            else
                                            {
                                                newPath += pathh[g] + "\\";
                                            }

                                            if (pathh[g] == "inputClasses")
                                            {
                                                savePath += "outputClasses" + "\\";
                                            }
                                            else if (pathh[g].Contains("." + tbEnding.Text))
                                            {
                                                savePath += obfuscatedKeywords[x] + "." + tbEnding.Text;
                                            }
                                            else
                                            {
                                                savePath += pathh[g] + "\\";
                                            }
                                        }

                                        savePath += obfuscatedKeywords[x] + "." + tbEnding.Text;

                                        if (!Directory.Exists(newPath))
                                        {
                                            Directory.CreateDirectory(newPath);
                                        }

                                        File.WriteAllText(savePath/*outputClassesPath + $@"\{obfuscatedKeywords[x]}.{classes[x].Split('.')[1]}"*/, obfuscatedClass);

                                        break;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                    args.status.addStepPB();
                }
            }
            catch (Exception ex)
            {
                args.status.Hide();

                args.status = null;

                MessageBox.Show("Error:\n" + ex.Message, "Simple Obfuscate");

                btnStartObfuscator.Enabled = true;

                return;
            }

            args.status.SetDoing("Finished!");

            args.status.SetPBMax();

            args.status.Update();

            Thread.Sleep(1000);

            args.status.Hide();

            args.status = null;

            MessageBox.Show("Successfully obfuscated classes!", "Simple Obfuscate");

            btnStartObfuscator.Enabled = true;
        }

        private void tbKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNewKeyword.PerformClick();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnStartObfuscator.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            fdb.ShowDialog();

            if (Directory.Exists(fdb.SelectedPath))
            {
                Copy(fdb.SelectedPath, inputClassesPath + $@"\{fdb.SelectedPath.Split('\\').Last()}");
            }
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void tbEnding_TextChanged(object sender, EventArgs e)
        {
            UpdateInputClasses();
        }
    }

    public class Args
    {
        public string[] keywords;

        public Status status;
    }

    public class ThreadArgs
    {
        public Status status; public string obfuscatedClass; public string[] classes; public int i; public string[] keywords; public string[] obfuscatedKeywords;
    }
}
