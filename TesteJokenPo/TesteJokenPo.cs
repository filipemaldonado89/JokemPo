using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System.Collections.Generic;

namespace TesteJokenPo
{
    [TestClass]
    public class TesteJokenPo
    {
        RPS rps = new RPS();
        Validacoes validate = new Validacoes();
        List<Tuple<string, string>> rodada = new List<Tuple<string, string>>();

        [TestMethod]
        public void Resultado_P_x_S()
        {      
            rodada.Add(new Tuple<string, string>("Armando", "P"));
            rodada.Add(new Tuple<string, string>("Dave", "S"));

            Assert.AreEqual(rps.ResultadoDuelo(rodada).Item2, "S");
        }

        [TestMethod]
        public void Resultado_P_x_R()
        {
            rodada.Add(new Tuple<string, string>("Armando", "P"));
            rodada.Add(new Tuple<string, string>("Richard", "R"));

            Assert.AreEqual(rps.ResultadoDuelo(rodada).Item2, "P");
        }

        [TestMethod]
        public void Resultado_S_x_R()
        {
            rodada.Add(new Tuple<string, string>("Richard", "R"));
            rodada.Add(new Tuple<string, string>("Michael", "S"));

            Assert.AreEqual(rps.ResultadoDuelo(rodada).Item2, "R");
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Validar_Quantidade_Inscritos_Minimo_2()
        {
            rodada.Add(new Tuple<string, string>("Richard", "R"));         

            validate.ValidarInscritos(rodada);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError))]
        public void Validar_Acao_Jogador()
        {
            rodada.Add(new Tuple<string, string>("Richard", "X"));
            rodada.Add(new Tuple<string, string>("Michael", "S"));

            validate.ValidarJogada(rodada);
        }
    }
}
