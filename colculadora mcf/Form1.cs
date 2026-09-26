using System;
using System.Collections.Generic;
using System.ComponentModel;    
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;


namespace colculadora_mcf
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        //cultura brasileira:usa virgula como separador decimal
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //indica se o ultimo comado foi o botão =
        bool novoCalculo = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //numeros
        private void adicionar numero(string numero)
        {
            //se acabou de calcular,coecar um novo numero
            if (novoCalculo)
            {
                txtResultado.Text = "";
                novoCalculo = false;
            }
            txtResultado.Text += numero;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            adicionarnumero("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            adicionarnumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            adicionarnumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            adicionarnumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            adicionarnumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            adicionarnumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            adicionarnumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            adicionarnumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            adicionarnumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            adicionarnumero("9");
        }
    }
}