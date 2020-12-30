using System;

namespace EmpresaAerea
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomes, sobrenome, cod_dest;
            int ano, mes, dia, hora, minuto;
            
            DateTime dataAtual = DateTime.Now;
            ano = dataAtual.Year;
            mes = dataAtual.Month;
            dia = dataAtual.Day;
            hora = dataAtual.Hour;
            minuto = dataAtual.Minute;

            Console.WriteLine("Escreva seu nome:");
            nomes = Console.ReadLine();
            Console.WriteLine("Escreva seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Informe o código de destino, POA - Porto Alegre ou GRU - São Paulo ou BSB - Brasilia: ");
            cod_dest = Console.ReadLine();

            Console.WriteLine("Passageiro: {0}, {1}", sobrenome, nomes);

            if (cod_dest == "POA")
            {
                Console.WriteLine("Destino: Porto Alegre");
            }
            else if (cod_dest == "GRU")
            {
                Console.WriteLine("Destino: São Paulo");
            }
            else if (cod_dest == "BSB")
            {
                Console.WriteLine("Destino: Brasilia");
            }

            Console.WriteLine("Codigo da passagem: {0}{1}{2}{3}{4}", ano, mes, dia, hora, minuto);

        }
    }
}
