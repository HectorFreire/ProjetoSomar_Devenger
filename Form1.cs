namespace ProjetoSomar_Devenger
{
    public partial class Form1 : Form
    {
        private GerenciarNumeros gerenciador = new GerenciarNumeros();

        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarListBox()
        {
            listNumeros.Items.Clear();
            foreach (int numero in gerenciador.ObterNumeros())
            {
                listNumeros.Items.Add(numero);
            }

            AtualizarContagem();
        }

        private void AtualizarContagem()
        {
            campoContagem.Text = "Total de números: " + gerenciador.ContarNumeros();
        }

        private void listNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void inputNumeros_TextChanged(object sender, EventArgs e)
        {
        }

        private void campoSoma_Click(object sender, EventArgs e)
        {
        }

        private void campoContagem_Click(object sender, EventArgs e)
        {
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (gerenciador.TemNumerosParaSomar())
            {
                int soma = gerenciador.SomarNumeros();
                campoSoma.Text = "Soma: " + soma.ToString();
            }
            else
            {
                MessageBox.Show("Não tem números para somar.");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (listNumeros.SelectedIndex != -1)
            {
                if (gerenciador.RemoverNumero(listNumeros.SelectedIndex))
                {
                    AtualizarListBox();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar remover o número.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um número para apagar.");
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputNumeros.Text))
            {
                if (int.TryParse(inputNumeros.Text, out int numero))
                {
                    gerenciador.AdicionarNumero(numero);
                    AtualizarListBox();
                    inputNumeros.Clear();
                }
                else
                {
                    MessageBox.Show("Insira um número válido.");
                }
            }
        }

        private void btnApagarAll_Click(object sender, EventArgs e)
        {
            gerenciador.LimparNumeros();
            AtualizarListBox();
        }
    }
}
