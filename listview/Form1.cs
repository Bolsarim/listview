using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxProduto.Clear();
            textBoxQuantidade.Clear();
            textBoxPreco.Clear();
            textBoxID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio, por favor preencha o ID");
                textBoxID.Focus();
                return;
            }
            if (textBoxProduto.Text == "")
            {
                MessageBox.Show("Produto Não pode ser vazio, por favor preencha o Produto");
                textBoxProduto.Focus();
                return;
            }
            if (textBoxQuantidade.Text == "")
            {
                MessageBox.Show("Quantidade Não pode ser vazio, por favor preencha a Quantidade");
                textBoxQuantidade.Focus();
                return;
            }
            if (textBoxPreco.Text == "")
            {
                MessageBox.Show("Preco Não pode ser vazio, por favor preencha o Preco");
                textBoxPreco.Focus();
                return;
            }
        }
    }
}
