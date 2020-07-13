using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace CleanPaste
{
    public partial class SettingsForm : Form
    {
        UserSettings settings;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings = new UserSettings();
            chkTextFormat.Checked = settings.RemoveTextFormattings;
            chkLineBreak.Checked = settings.RemoveLineBreaks;
            chkUnicode.Checked = settings.RemoveUnicodeChars;
            chkConvertToHTML.Checked = settings.ConvertToHTML;
            chkAutoStart.Checked = settings.AutoStart;
            chkAddLineBreaks.Checked = settings.AddLineBreaks;
            txtLineBreaks.Text = settings.AddLineBreaksAfter;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            settings.RemoveTextFormattings = chkTextFormat.Checked;
            settings.RemoveLineBreaks = chkLineBreak.Checked;
            settings.RemoveUnicodeChars = chkUnicode.Checked;
            settings.ConvertToHTML = chkConvertToHTML.Checked;
            settings.AutoStart = chkAutoStart.Checked;
            settings.AddLineBreaks = chkAddLineBreaks.Checked;
            settings.AddLineBreaksAfter = txtLineBreaks.Text;



            string name = "CleanPaste";
            string location = Process.GetCurrentProcess().MainModule.FileName;

            if (settings.AutoStart)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue(name, location);
            }
            else
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (key.GetValueNames().Contains(name))
                    key.DeleteValue(name);
            }
            settings.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkConvertToHTML_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConvertToHTML.Checked)
            {
                chkTextFormat.Checked = false;
                chkLineBreak.Checked = false;
                chkUnicode.Checked = false;
                chkAddLineBreaks.Checked = false;
            }
        }

        private void chkLineBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLineBreak.Checked)
            {
                chkTextFormat.Checked = true;
            }
        }


        private void chkUnicode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnicode.Checked)
            {
                chkTextFormat.Checked = true;
            }
        }

        private void chkAddLineBreaks_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddLineBreaks.Checked)
            {
                chkTextFormat.Checked = true;
                chkLineBreak.Checked = false;
            }
        }

        private void chkTextFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkTextFormat.Checked)
            {

                chkLineBreak.Checked = false;
                chkUnicode.Checked = false;
                chkAddLineBreaks.Checked = false;
            }
            else
                chkConvertToHTML.Checked = false;
        }     
    }
}
