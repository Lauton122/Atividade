namespace Estrutura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, insira um nome válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            if (!int.TryParse(txtIdade.Text, out idade) || idade < 0)
            {
                MessageBox.Show("Por favor, insira uma idade válida (número inteiro não negativo).", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }   


