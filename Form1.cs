namespace ProjetoSomar_Devenger
{
    public partial class Form1 : Form
    {
        // Olá Richard!! Aqui vais alguns detalhes da aplicação:
        // Decidir usar array pois garante que o número selecionado será o número removido. Atraves dos indices!
        // Adicionei alguns métodos validadores para evitar erro:
        // -- verificar se o input do campo é número, se for texto não aceita
        // -- se há números para a soma
        // -- se tem algum número selecionado para ser removido
        // Além de adicionar um botão onde remove todos os numeros do array e um contador de números
        // Intanciei e adicionei a classe "GerenciarNumeros" para que ficasse uma POO 

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
