using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class RPS : IRPS
    {
        private static List<Tuple<string, string>> inscritos = new List<Tuple<string, string>>();
        private static List<List<Tuple<string, string>>> rodadas = new List<List<Tuple<string, string>>>();

        public RPS(List<Tuple<string, string>> _inscritos)
        {
            inscritos = _inscritos;            
        }

        public RPS()
        {            
        }

        public void RpsTournamentWinner()
        {
            var duelo = new List<Tuple<string, string>>();

            foreach (var inscrito in inscritos)
            {
                duelo.Add(inscrito);

                if (duelo.Count() == 2)
                {
                    rodadas.Add(duelo);
                    duelo = new List<Tuple<string, string>>();
                }
            }
            RpsGameWinner();
        }

        

        public void RpsGameWinner()
        {
            var vencedores = new List<Tuple<string, string>>();
            var vencedoresRodada = new List<List<Tuple<string, string>>>();
            var validate = new Validacoes();

            int count = 1;

            vencedores = inscritos;
            vencedores = new List<Tuple<string, string>>();

            Console.WriteLine();
            Console.WriteLine("Confrontos: ");
            Console.WriteLine();

            do
            {
                if (rodadas.Count() == 1)
                    Console.WriteLine("Final: ");
                else
                    Console.WriteLine("{0}ª Etapa: ", count);

                count++;

                Console.WriteLine(); 
                vencedoresRodada = new List<List<Tuple<string, string>>>();

                foreach (var rodada in rodadas)
                {
                    validate.ValidarJogada(rodada);
                    
                    Tuple<string, string> vencedor = null;
                   
                    Console.WriteLine("{0} - {1} vs {2} - {3}", rodada[0].Item1, rodada[0].Item2, rodada[1].Item1, rodada[1].Item2);

                    vencedor = ResultadoDuelo(rodada);

                    vencedores.Add(vencedor);
                    
                    Console.WriteLine(string.Format("Vencedor: {0} - Acão: {1}", vencedor.Item1, vencedor.Item2));
                    Console.WriteLine();

                    if (vencedores.Count() == 2)
                    {
                        vencedoresRodada.Add(vencedores);
                        vencedores = new List<Tuple<string, string>>();
                    }
                
                }

                rodadas = vencedoresRodada;
                Console.ReadKey();

            } while (vencedoresRodada.Count() != 0);
            
        }

        public Tuple<string, string> ResultadoDuelo(List<Tuple<string, string>> rodada)
        {
             Tuple<string, string> vencedor = null;

            if (rodada[0].Item2.Equals("R"))
            {
                if (rodada[1].Item2.Equals("S") || rodada[1].Item2.Equals("R"))
                    vencedor = rodada[0];
                else
                    vencedor = rodada[1];

            }
            if (rodada[0].Item2.Equals("S"))
            {
                if (rodada[1].Item2.Equals("P") || rodada[1].Item2.Equals("S"))
                    vencedor = rodada[0];
                else
                    vencedor = rodada[1];
            }

            if (rodada[0].Item2.Equals("P"))
            {
                if (rodada[1].Item2.Equals("R") || rodada[1].Item2.Equals("P"))
                    vencedor = rodada[0];
                else
                    vencedor = rodada[1];
            }
            return vencedor;
        }

                     
    }
}
