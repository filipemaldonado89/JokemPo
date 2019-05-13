using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Jogadores : IJogadores
    {     
        public List<Tuple<string, string>> Inscritos()
        {
            var inscritos = new List<Tuple<string, string>>();

            inscritos.Add(new Tuple<string, string>( "Armando", "P"));
            inscritos.Add(new Tuple<string, string>("Dave", "S"));
            inscritos.Add(new Tuple<string, string>("Richard", "R"));
            inscritos.Add(new Tuple<string, string>("Michael", "S"));
            inscritos.Add(new Tuple<string, string>("Allen", "S"));
            inscritos.Add(new Tuple<string, string>("Omer", "P"));
            inscritos.Add(new Tuple<string, string>("David E.", "R"));
            inscritos.Add(new Tuple<string, string>("Richard X.", "P"));

            return inscritos;
        }
    }
}
