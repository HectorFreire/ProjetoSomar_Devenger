namespace ProjetoSomar_Devenger
{
    public partial class Form1 : Form
    {

        private GerenciarNumeros gerenciador = new GerenciarNumeros(); // Instância da classe para manipular
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarListBox()
        {
            listNumeros.Items.Clear();
            foreach (int numero in gerenciador.ObterNumeros()) //array para add os números
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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (gerenciador.ContarNumeros() > 0)
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
                gerenciador.RemoverNumero(listNumeros.SelectedIndex);

                AtualizarListBox();
            }
            else
            {
                MessageBox.Show("selecione um número para apagar.");
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
                    MessageBox.Show("insira um número válido");
                }
            }
        }

        private void campoSoma_Click(object sender, EventArgs e)
        {

        }

        private void btnApagarAll_Click(object sender, EventArgs e)
        {
            gerenciador.LimparNumeros();
            AtualizarListBox();
        }

        private void campoContagem_Click(object sender, EventArgs e)
        {

        }
    }
}
