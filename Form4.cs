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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            textBoxId.Clear();
            textBoxProduct.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
            textBoxId.Focus();
        }

        private void obterValores()
        {
            textBoxId.Text = listViewProducts.SelectedItems[0].SubItems[0].Text;
            textBoxProduct.Text = listViewProducts.SelectedItems[0].SubItems[1].Text;
            textBoxQuantity.Text = listViewProducts.SelectedItems[0].SubItems[2].Text;
            textBoxPrice.Text = listViewProducts.SelectedItems[0].SubItems[3].Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] products = new string[4];

            products[0] = textBoxId.Text;
            products[1] = textBoxProduct.Text;
            products[2] = textBoxQuantity.Text;
            products[3] = textBoxPrice.Text;

            ListViewItem lista = new ListViewItem(products);

            listViewProducts.Items.Add(lista);
            limpar();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listViewProducts.Items.RemoveAt(listViewProducts.SelectedIndices[0]);
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            obterValores();
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                obterValores();
            }
            catch
            {
                MessageBox.Show("OPSS");
            }
        }

    }
}
