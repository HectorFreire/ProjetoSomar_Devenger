using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSomar_Devenger
{
    internal class GerenciarNumeros
    {
        // array que será manipulado
        private List<int> numeros = new List<int>();

        public void AdicionarNumero(int numero)
        {
            numeros.Add(numero);
        }

        public void RemoverNumero(int index)
        {
            if (index >= 0 && index < numeros.Count)
            {
                numeros.RemoveAt(index);
            }
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
    }
}
