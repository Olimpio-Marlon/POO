using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public class Pessoa
        {
            public string Name { get; set; }

            public int Idade { get; set; }

            public string Profissao { get; set; }

            public int Salario { get; set; }

            
            public void Apresentar()
            {
                Console.Write($"Olá me chamo {Name} tenho {Idade} anos e sou {Profissao} e ganho {Salario}");
            }
        }

        


    }
}
