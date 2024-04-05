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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            linkLabelDiversos.Links.Add(0,6,"www.google.com.br");
            linkLabelDiversos.Links.Add(7, 5, "www.youtube.com/cfbcursos");
            linkLabelDiversos.Links.Add(13, 7, "www.youtube.com");
        }

        private void linkLabelCanal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos");
        }

        private void linkLabelCalculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void linkLabelDiversos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
