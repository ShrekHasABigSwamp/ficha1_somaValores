using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha1_somaValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            textBox_1valor.BackColor = Color.White;
            textBox_2valor.BackColor = Color.White;

            double num_1, num_2, resultado;

            if (textBox_1valor.Text == string.Empty)
            {
                textBox_1valor.BackColor = Color.GreenYellow;
                MessageBox.Show("Digite o 1º número!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_2valor.Text == string.Empty)
            {
                textBox_2valor.BackColor = Color.GreenYellow;
                MessageBox.Show("Digite o 2º número!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (! Double.TryParse(textBox_1valor.Text, out num_1))
            {
                textBox_1valor.BackColor = Color.GreenYellow;
                MessageBox.Show("Houve um erro na inserção do 1º número!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (! Double.TryParse(textBox_2valor.Text, out num_2))
            {
                textBox_2valor.BackColor = Color.GreenYellow;
                MessageBox.Show("Houve um erro na inserção do 2º número!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                resultado = num_1 + num_2;
                textBox_resultado.Text = resultado.ToString();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox_1valor.BackColor = Color.White;
            textBox_2valor.BackColor = Color.White;

            textBox_1valor.Clear();
            textBox_2valor.Clear();
            textBox_resultado.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
