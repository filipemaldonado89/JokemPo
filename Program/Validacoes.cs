using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Validacoes : IValidacoes
    {
        public void ValidarInscritos(List<Tuple<string, string>> inscritos)
        {
            if (inscritos.Count < 2)
                throw new WrongNumberOfPlayersError("Pelo menos 2 jogadres são necessários para iniciar!");

        }

        public void ValidarJogada(List<Tuple<string, string>> rodada)
        {
            if ((!rodada[0].Item2.Equals("P") && !rodada[0].Item2.Equals("R") && !rodada[0].Item2.Equals("S")) ||
                        (!rodada[1].Item2.Equals("P") && !rodada[1].Item2.Equals("R") && !rodada[1].Item2.Equals("S")))
                throw new WrongNumberOfPlayersError("Ação inválida!!");
        }
    }
}
