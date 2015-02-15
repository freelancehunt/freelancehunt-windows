using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace freelancehunt
{
    public partial class frmLogin : Form
    {
        string fileParam = Application.StartupPath + @"\param.txt";

        public frmLogin()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            this.Left = (rect.Width - this.Width) / 2;
            this.Top = (rect.Height - this.Height) / 2;

            if (File.Exists(fileParam))
            {
                try
                {
                    using (StreamReader rd = new StreamReader(fileParam, Encoding.GetEncoding(1251)))
                    {
                        txtLogin.Text = rd.ReadLine();
                        txtPass.Text = rd.ReadLine();

                        rd.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка в файле параметров входа", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "") { return; }
            if (txtPass.Text.Trim() == "") { return; }
            txtLogin.Text = txtLogin.Text.Trim();
            txtPass.Text = txtPass.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            this.Dispose();
            try { Process.GetCurrentProcess().Kill(); }
            catch (Exception) { }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text == "") { label1.Visible = true; }
            else { label1.Visible = false; }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "") { label2.Visible = true; }
            else { label2.Visible = false; }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
