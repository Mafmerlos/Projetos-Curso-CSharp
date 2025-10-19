using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFomrs.Models;

namespace WinFomrs
{
    public partial class Form1 : Form
    {
        Models.Carrinho car1;
        public Form1()
        {
            InitializeComponent();
            car1 = new Carrinho();
            Models.Cliente c1 = new Models.Cliente();
            c1.Nome = "Joca";
        }

        private void btnCarregarCarrinho_Click(object sender, EventArgs e)
        {            
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Models.Produto p1 = new Models.Produto("Arroz", "Comida", rnd.Next(800));

            car1.AdicionarProduto(p1);

            //Atualização de tela...
            dgwItensCarrinho.DataSource = null;
            dgwItensCarrinho.DataSource = car1.Produtos;
            lblValorTotal.Text = car1.ValorTotal.ToString();
        }
    }
}
