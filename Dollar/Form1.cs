namespace Dollar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Cotacao, Reais, Dolar;

            if (double.TryParse(txtCotacao.Text, out Cotacao) && double.TryParse(txtCotacao.Text, out Reais))
            {
                Dolar = Reais / Cotacao;
                txtDolares.Text = $"O valor em dólares é: {Dolar:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para a cotação e o valor em reais.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
