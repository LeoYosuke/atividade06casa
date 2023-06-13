
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            string periodo;

            Console.WriteLine("Olá seja Bem-vindo ao FABIO-AIR!");
            Console.WriteLine("Qual mês você deseja viajar:\n08-Agosto\n09-Setembro\n10-Outubro");
            mes = Int32.Parse(Console.ReadLine());

            int dia;

            if(mes == 8 || mes == 9 ||mes== 10 || mes == 08 || mes == 09) 
            {
                Console.WriteLine("Agora escolha o dia da viagem");
                dia = Int32.Parse(Console.ReadLine());
                if (dia >= 6 && dia <= 21) 
                {
                    Console.WriteLine("Qual o periodo deseja comprar a passagem:");
                    Console.WriteLine("Tarde:\nManhã:\nNoite:");
                    periodo = (Console.ReadLine());
                    Console.WriteLine("Parabens passagem confirmada");
                    Console.WriteLine($"Mês:{mes}");
                    Console.WriteLine($"Dia:{dia}");
                    Console.WriteLine($"Periodo:{periodo}");
                    

                }
                else 
                {
                    Console.WriteLine("Dia invalido");
                    Main(null);
                    return;
                }


            }
            else
            {
                Console.WriteLine("mes invalido");
                Main(null);
            }

            Console.ReadKey();
            
            
            


        }
    }
}
