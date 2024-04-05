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
    public partial class Form3 : Form
    {
        List<string> cars = new List<string>();

        public Form3()
        {
            InitializeComponent();

            cars.Add("Kia");
            cars.Add("Fiat");
            cars.Add("Hyundai");

            listBoxCar.DataSource = cars;
        }

        // Função
        private void atualizarListBoxCar()
        {
            listBoxCar.DataSource = null;
            listBoxCar.DataSource = cars;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxCar ==  null)
            {
                MessageBox.Show("Digite algo!");
                textBoxCar.Focus();
            }
            else
            {
                cars.Add((string)textBoxCar.Text);
                textBoxCar.Clear();
                atualizarListBoxCar();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            cars.RemoveAt(listBoxCar.SelectedIndex);
            atualizarListBoxCar();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            String selected = cars[listBoxCar.SelectedIndex];
            MessageBox.Show(selected);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cars.Clear();
            atualizarListBoxCar();
        }
    }
}
