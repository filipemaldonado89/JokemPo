using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public interface IJogadores
    {
        List<Tuple<string, string>> Inscritos();
    }
}
