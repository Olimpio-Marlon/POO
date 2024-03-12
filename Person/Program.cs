using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Person.Person;

Pessoa person = new Pessoa();


//person.Name = "Marlon";
Console.Write("Digite o seu nome: ");
person.Name = Convert.ToString(Console.ReadLine());
Console.Write("Digite a sua idade: ");
person.Idade = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a sua profissão: ");
person.Profissao = Convert.ToString(Console.ReadLine());
Console.Write("Digite o seu salário: ");
person.Salario = Convert.ToInt32(Console.ReadLine());

// Duas maneiras de utilizar o objeto

person.Apresentar();

Console.WriteLine($"Oi me chamo {person.Name} tenho {person.Idade} anos sou {person.Profissao} e meu salário eh {person.Salario}");

Console.ReadKey();