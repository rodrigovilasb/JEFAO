using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Cliente :Pessoa
    {
        public class Cliente
        {
            private int codigo;

            public void DefinirCodigo(int c)
            {
                codigo = c;
            }
            public void MostrarCodigo()
            {
                Console.WriteLine("Codigo do cliente: " + codigo);

            }
         
        }



    }
}
