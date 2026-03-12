namespace CF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit;

            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = $"A temperatura em °F é: {fahrenheit:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para a temperatura em °C.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
