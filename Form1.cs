using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetDate_Click(object sender, EventArgs e)
        {
            textBoxFullDate.Text = dateTimePicker.Text;
        
            textBoxDay.Text = dateTimePicker.Value.Day.ToString();
            textBoxMonth.Text = dateTimePicker.Value.Month.ToString();
            textBoxYear.Text = dateTimePicker.Value.Year.ToString();
        }

        private void buttonSetDate_Click(object sender, EventArgs e)
        {
            int day, month, year;

            day = Int32.Parse(textBoxDay.Text);
            month = Int32.Parse(textBoxMonth.Text);
            year = Int32.Parse(textBoxYear.Text);

            DateTime dateTime = new DateTime(year, month, day);

            dateTimePicker.Value = dateTime;
        }

        private void buttonOpenNewForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void menu3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void menu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void menu6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void MenuNotificacao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "toolStripMenuItemClose")
            {
                this.Close();
            } else if (e.ClickedItem.Name.ToString() == "toolStripMenuItemRestore")
            {
                this.WindowState = FormWindowState.Normal;
            } else if (e.ClickedItem.Name.ToString() == "toolStripMenuItemMessage")
            {
                MessageBox.Show("It's ok");
            }
        }
    }
}
