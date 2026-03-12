namespace Passagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, preco;

            distancia = Convert.ToDouble(txtDistancia.Text);

            if (distancia <= 200)
            {
                preco = distancia * 0.50;
            }
            else
            {
                preco = distancia * 0.45;
            }

            lblResultado.Text = $"O preço da passagem é: R$ {preco:F2}";
        }
    }
}
