using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var funcionarios = new Funcionario[1];
            funcionarios[0] = new Funcionario() { Id = 2574, Name = "Cauan"};
            

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.Id} - Nome: {funcionario.Name}");
                
            }
            Console.ReadLine();
        }
     
        public struct Funcionario
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }

        

    }
}
