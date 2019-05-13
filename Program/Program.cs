using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static List<Tuple<string, string>> inscritos;

        static void Main(string[] args)
        {
            var jogadores = new Jogadores();
            inscritos = jogadores.Inscritos();

            var validate = new Validacoes();
            var rps = new RPS(inscritos);

            validate.ValidarInscritos(inscritos);

            Console.Title = ("JokenPo"); 
            Console.WriteLine("Pressione Enter para começar");
            Console.Read();
            Console.WriteLine("Inscritos: ");
            Console.WriteLine();

            foreach (var inscrito in inscritos)
                Console.WriteLine("Nome: " + inscrito.Item1 + " - Acão: " + inscrito.Item2);

            rps.RpsTournamentWinner();

            Console.ReadKey();
            Console.Clear();
        }
    }

}

