using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public interface IValidacoes
    {
        void ValidarInscritos(List<Tuple<string, string>> inscritos);       
        void ValidarJogada(List<Tuple<string, string>> rodada);
    }
}
