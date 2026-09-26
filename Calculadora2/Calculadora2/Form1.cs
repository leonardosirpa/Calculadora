using System.Drawing.Text;
using System.Globalization;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        //Cultura Brasileira: usa vírgula como separador decimal
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //Indica se o ultimo comando foi o botão for =
        bool novoCalculo = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionarNumero ("0")
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1")
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2")
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3")
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4")
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5")
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6")
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7")
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8")
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9")
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            // Números
            Private void AdicionarNumero(String numero)

            {//Se acabou de calcular, começa um novo numero
                if(novoCalculo)
                {
                    txtResultado.Text = "";
                    novoCalculo = false;
                  }
                txtResultado.Text += numero;
                
                 }


        }
    }
}
