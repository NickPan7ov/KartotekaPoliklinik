using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartotekaPoliklinik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int number;
            InitializeComponent();
            Random rd = new Random();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                this.Hide();
                MessageBox.Show("Успешная авторизация");
                MainForm fr = new MainForm();
                fr.ShowDialog();
                
                
            }
            else
            {
               MessageBox.Show("Пароль неверен");
            }
        }
    }
}
