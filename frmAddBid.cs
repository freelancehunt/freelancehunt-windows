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
    public partial class frmAddBid : Form
    {
        string projUrl = string.Empty;
        bool sf_proj = false;


        int days_to_deliver = 0;   //время выполнения работы, целое положительное число не более 180
        int amount = 0;           //желаемая оплата за проект, целое положительное число
        string currency_code = String.Empty;    //валюта, также доступны значения 'USD', 'RUB', 'UAH'
        bool is_safe_project;  //0 если фрилансер не желает резервировать оплату в Сейфе. для Сейфа сумма оплаты должны быть не менее 200 грн., 20$ или 750 руб. http://feedback.freelancehunt.com/topic/531579-rezervirovanie-summyi-zakazchikom/)
        string comment = String.Empty;   //текст ставки


        string err_code = String.Empty;
        string err_message = String.Empty;



        public frmAddBid(string url, bool is_sf_prj)
        {
            this.sf_proj = is_sf_prj;

            if (url != String.Empty) { projUrl = url; }
            else this.Close();
            
            InitializeComponent();
            
            
        }

        private void loadData() {
            days_to_deliver = Convert.ToInt16(numericUpDown2.Value);
            amount = Convert.ToInt16(numericUpDown1.Value);
            currency_code = comboBox1.Text.Trim();
            is_safe_project = checkBox1.Checked;
            comment = textBox1.Text;
        }

        private bool validateData() 
        {
            if (days_to_deliver < 1 || days_to_deliver > 180) { 
                MessageBox.Show("Время выполнения работы не может быть более 180 дней", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (amount > 0 && currency_code == String.Empty) {
                MessageBox.Show("Не выбрана валюта стоимости проекта", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            //для Сейфа сумма оплаты должны быть не менее 200 грн., 20$ или 750 руб.
            if (is_safe_project) {
                if (amount < 200 && currency_code == "UAH")
                { MessageBox.Show("Для Сейфа сумма оплаты должны быть не менее 200 грн.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                if (amount < 20 && currency_code == "USD")
                { MessageBox.Show("Для Сейфа сумма оплаты должны быть не менее 20$", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                if (amount < 750 && currency_code == "RUB")
                { MessageBox.Show("Для Сейфа сумма оплаты должны быть не менее 750 руб.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            if (comment.Trim() == String.Empty) {
                MessageBox.Show("Комментарий не может быть пустым!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
            if (!validateData()) { return; }

            string res = clsUpdate.addBid(days_to_deliver, amount, currency_code, is_safe_project, comment, projUrl);

            #region обработка ответа
            if (res.Trim() == "") 
            { 
                MessageBox.Show("Ставка добавлена", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                button1.Visible = false;
                this.Close();
            } else {

                if (res.Contains("error"))
                {
                    if (res.Contains("\"code\":429"))
                    {
                        MessageBox.Show("Превышено допустимое число добавления ставок в день. \nСтавка не добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else if (res.Contains("Project bidding is not allowed"))
                    {
                        MessageBox.Show("Вы не можете добавить ставку, возможно потому что вы уже добавили ставку ранее. \nСтавка не добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        string emsg = res.Remove(0, res.LastIndexOf(':') + 1);
                        emsg = emsg.Remove(emsg.LastIndexOf('\"'));
                        MessageBox.Show(emsg);
                    } 
                }
            }
            #endregion
        }


        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            if (numericUpDown1.Value == 0 && e.KeyChar == '0') { comboBox1.Enabled = false; }
            else { comboBox1.Enabled = true; }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = true; }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0) { comboBox1.Enabled = false; }
            else { comboBox1.Enabled = true; }
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void frmAddBid_Load(object sender, EventArgs e)
        {
            if (sf_proj) {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>')
            { e.Handled = true; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region перемещение формы по экрану

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmAddBid_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmAddBid_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmAddBid_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion



    }
}
