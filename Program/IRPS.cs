using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public interface IRPS
    {
        void RpsTournamentWinner();
        void RpsGameWinner();
        Tuple<string, string> ResultadoDuelo(List<Tuple<string, string>> rodada);
    }
}
