using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace freelancehunt
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            chBxAutoRun.Checked = clsConfig.AutoRun;
            chBxAutoLogin.Checked = clsConfig.AutoLogin;
            chBxStartHidden.Checked = clsConfig.StartHidden;
            chBxNotifyInterestProjOnly.Checked = clsConfig.NotifyInterestProjOnly;
            
            chBxIsHide.Checked = clsConfig.AutoHideUpdateWindow;

            if (clsConfig.ShowInterestProjOnly) { chBxNotifyInterestProjOnly.Enabled = false; }

            if (chBxIsHide.Checked)
            {
                label1.Enabled = true;
                nUDShowTime.Enabled = true;
            } else {
                label1.Enabled = false;
                nUDShowTime.Enabled = false;
            }

            chBxIsShow.Checked = clsConfig.ShowUpdateWindow;

            if (chBxIsShow.Checked)
            {
                chBxIsHide.Enabled = true;
            }
            else
            {
                chBxIsHide.Checked = false;
                chBxIsHide.Enabled = false;
            }

            //chBxSound.Checked = clsConfig.SoundNotification;

            if (clsConfig.UpdateFreq > 0) { nUDShowTime.Maximum = clsConfig.UpdateFreq * 60 - 1; }
            else { nUDShowTime.Maximum = 1; }
            nUDShowTime.Value = clsConfig.HideUpdateWindowTime;
            nUDUpdFreq.Value = clsConfig.UpdateFreq;
            
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxIsHide.Checked)
            {
                label1.Enabled = true;
                nUDShowTime.Enabled = true;
            } else {
                label1.Enabled = false;
                nUDShowTime.Enabled = false;
            }
        }
        
        private void chBxIsShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxIsShow.Checked)
            {
                chBxIsHide.Enabled = true;
            }
            else
            {
                chBxIsHide.Checked = false;
                chBxIsHide.Enabled = false;
            }
        }

        private void chBxStartHidden_CheckedChanged(object sender, EventArgs e)
        {
            //chBxStartHidden.Checked = clsConfig.AutoHideUpdateWindow;
            //if (chBxIsHide.Checked)
            //{
            //    label1.Visible = txtShowTime.Visible = true;
            //} else {
            //    label1.Visible = txtShowTime.Visible = false;
            //}
        }


        private static void SetAutorunValue(bool autorun)
        {
            const string name = "Freelancehunt_Monitor";
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun) { reg.SetValue(name, ExePath); }
                else { reg.DeleteValue(name); }
                reg.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            //MessageBox.Show("Добавлено!");
            //return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Идет Сохранение";
            //if (txtShowTime.Text.Trim() == "" || Convert.ToInt32(txtShowTime.Text) < 1) 
            //{ txtShowTime.Text = clsConfig.HideUpdateWindowTime.ToString();}

            //if (txtUpdFreq.Text.Trim() == "" || Convert.ToInt32(txtUpdFreq.Text) < 1)
            //{ txtUpdFreq.Text = clsConfig.UpdateFreq.ToString();}

            if (clsConfig.AutoRun != chBxAutoRun.Checked) {
                SetAutorunValue(chBxAutoRun.Checked);
            }

            if (clsConfig.ShowInterestProjOnly) { chBxNotifyInterestProjOnly.Checked = true; }

            clsConfig.AutoRun = chBxAutoRun.Checked;
            clsConfig.AutoLogin = chBxAutoLogin.Checked;
            clsConfig.StartHidden = chBxStartHidden.Checked;
            clsConfig.NotifyInterestProjOnly = chBxNotifyInterestProjOnly.Checked;
            clsConfig.ShowUpdateWindow = chBxIsShow.Checked;
            clsConfig.AutoHideUpdateWindow = chBxIsHide.Checked;
            //clsConfig.SoundNotification = chBxSound.Checked;
            clsConfig.UpdateFreq = Convert.ToInt32(nUDUpdFreq.Value);
            clsConfig.HideUpdateWindowTime = Convert.ToInt32(nUDShowTime.Value);

            clsConfig.saveConfig();

            button1.Text = "Сохранить";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { this.Close(); }
        
        private void txtShowTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void nUDUpdFreq_ValueChanged(object sender, EventArgs e)
        {
            nUDShowTime.Maximum = nUDUpdFreq.Value * 60 - 1;
        }





       
    }
}
