﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // Tente fazer isso com eventos
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInicialDate.Text =  monthCalendar1.SelectionStart.ToShortDateString();
            textBoxFinalDate.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }
    }
}
