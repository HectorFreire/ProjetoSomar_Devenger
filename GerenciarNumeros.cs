namespace ProjetoSomar_Devenger
{
    internal class GerenciarNumeros
    {
        private List<int> numeros = new List<int>();

        public void AdicionarNumero(int numero)
        {
            numeros.Add(numero);
        }

        public bool RemoverNumero(int index)
        {
            if (index >= 0 && index < numeros.Count)
            {
                numeros.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void LimparNumeros()
        {
            numeros.Clear();
        }

        public int SomarNumeros()
        {
            return numeros.Sum();
        }

        public int ContarNumeros()
        {
            return numeros.Count;
        }

        public List<int> ObterNumeros()
        {
            return new List<int>(numeros);
        }

        public bool TemNumerosParaSomar()
        {
            return numeros.Count > 0;
        }
    }
}
