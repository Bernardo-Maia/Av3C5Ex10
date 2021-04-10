using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C5Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "" && txtNome.Text != "")
            {
                int quantidade = int.Parse(txtQuantidade.Text);
                double preco = 1.99, desconto = 1, valor;
                string nome = txtNome.Text;

                if (quantidade > 0)
                {

                    if (quantidade < 10) { desconto = 1; }
                    if (quantidade > 10 && quantidade <= 25) { desconto = 0.95; }
                    if (quantidade > 25) { desconto = 0.92; }
                    valor = preco * quantidade * desconto;
                    MessageBox.Show(nome + " Devera pagar R$:" + String.Format("{0:0.00}", valor) + " por " + quantidade + " produtos");

                }
                else { MessageBox.Show("Digite uma quantidade valida"); }
                
            }
            else { MessageBox.Show("Preencha todos os campos"); }
            txtNome.Text = "";
            txtQuantidade.Text = "";
        }
    }
}
