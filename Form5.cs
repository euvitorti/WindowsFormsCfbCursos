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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            switch (checkBoxOnlyText.Checked)
            {
                case true:
                    maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    break;
                case false:
                    maskedTextBoxCep.TextMaskFormat = MaskFormat.IncludeLiterals;
                    break;

            }
            String message = maskedTextBoxCep.Text;
             MessageBox.Show(message);
            //String message = maskedTextBoxCpf.Text;
            // MessageBox.Show(message);
        }
    }
}
