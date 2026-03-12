namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumero.Text, out numero))
            {
                lstTabuada.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    lstTabuada.Items.Add($"{numero} x {i} = {numero * i}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
