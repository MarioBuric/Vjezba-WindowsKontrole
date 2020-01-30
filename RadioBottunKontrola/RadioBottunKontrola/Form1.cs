using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBottunKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (radioButtonAvion.Checked)
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            else if (radioButtonAutobus.Checked)
                textBox1.Text = "Odabrali ste prijevoz autobusom.";
            else if (radioButtonVlastiti.Checked)
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            else
            {
                // u slucaju da nista nije odabrano
                MessageBox.Show("Odaberite tip prijevoza.");
                return;
            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRezerviraj_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
