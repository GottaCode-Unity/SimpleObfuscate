using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleObfuscate
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        public void SetMaxPB(int count)
        {
            pbProgress.Value = 0;

            pbProgress.Maximum = count + 1;
        }

        public void SetPBMax()
        {
            pbProgress.Value = pbProgress.Maximum;
        }

        public void addStepPB()
        {
            try
            {
                pbProgress.Value++;
            }
            catch (Exception)
            {

            }

            if (pbProgress.Value == pbProgress.Maximum)
            {
                Update();

                Thread.Sleep(1000); 

                Hide();
            }
        }

        public void SetDoing(string doing)
        {
            lblDoing.Text = doing;
        }

        public void SetMaxPBKeywords(int count)
        {
            pbProgressKeywords.Value = 0;

            pbProgressKeywords.Maximum = count + 1;
        }

        public void SetPBMaxKeywords()
        {
            pbProgressKeywords.Value = pbProgressKeywords.Maximum;
        }

        public void addStepPBKeywords()
        {
            try
            {
                pbProgressKeywords.Value++;
            }
            catch (Exception)
            {
            }
        }

        public void SetDoingKeywords(string doing)
        {
            lblKeywordStatus.Text = doing;
        }

        public void SetMaxPBClass(int count)
        {
            pbProgressClass.Value = 0;

            pbProgressClass.Maximum = count + 1;
        }

        public void SetPBMaxClass()
        {
            pbProgressClass.Value = pbProgressClass.Maximum;
        }

        public void addStepPBClass()
        {
            try
            {
                pbProgressClass.Value++;
            }
            catch (Exception ex)
            { 
            }
        }

        public void SetDoingClass(string doing)
        {
            lblClassStatus.Text = doing;
        }

        private void Status_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
