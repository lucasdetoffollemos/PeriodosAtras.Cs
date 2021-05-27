using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PeriodosAtras;

namespace PeriodosAtras.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveRetornarTotalDiasDecorridos()
        {
            DateTime dataInformada = new DateTime(2020, 05, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual(365, data.tempoTotalDecorridoDias);
        }

        [TestMethod]
        public void DeveRetornarTotalAnosDecorridos()
        {
            DateTime dataInformada = new DateTime(2015, 05, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual(6, data.anosDecorridos);
        }

        [TestMethod]
        public void DeveRetornarTotalMesesDecorridos()
        {
            DateTime dataInformada = new DateTime(2015, 01, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual(4, data.mesesDecorridos);
        }

        [TestMethod]
        public void DeveRetornarTotalSemanasDecorridos()
        {
            DateTime dataInformada = new DateTime(2021, 04, 27);
            Data data = new Data(dataInformada);

            Assert.AreEqual(4, data.semanasDecorridas);
        }

        [TestMethod]
        public void DeveRetornarDiasDecorridos()
        {
            DateTime dataInformada = new DateTime(2021, 05, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual(6, data.diasDecorridos);
        }

        [TestMethod]
        public void DeveRetornarSeisDiasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 05, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual("seis dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarUmaSemanaAtras()
        {
            DateTime dataInformada = new DateTime(2021, 05, 19);
            Data data = new Data(dataInformada);

            Assert.AreEqual("uma semana atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMesesUmaSemanaAtras()
        {
            DateTime dataInformada = new DateTime(2021, 03, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dois mêses e uma semana atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMesesDoisDiasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 03, 25);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dois mêses e dois dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDezAnosAtras()
        {
            DateTime dataInformada = new DateTime(2011, 05, 29);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dez anos atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDataInvalida()
        {
            DateTime dataInformada = new DateTime(2021, 05, 27);
            Data data = new Data(dataInformada);

            Assert.AreEqual("Data no Futuro", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarQuatroSemanasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 04, 28);
            Data data = new Data(dataInformada);

            Assert.AreEqual("quatro semanas atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarUmMesAtras()
        {
            DateTime dataInformada = new DateTime(2021, 04, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual("um mês atrás", data.resultado);
        }

        [TestMethod]
        public void NaoDeveRetornarHorario()
        {
            DateTime dataInformada = new DateTime(2021, 04, 25, 4, 9, 50);
            Data data = new Data(dataInformada);

            Assert.AreEqual("um mês e um dia atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarAsHorasDoComecoDodia()
        {
            DateTime dataInformada = new DateTime(2021, 05, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dezesseis horas e cinquenta minutos e vinte segundos atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornar5Horas()
        {
            DateTime dataInformada = new DateTime(2021, 05, 26, 11, 50, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual("cinco horas atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornar30Minutos()
        {
            DateTime dataInformada = new DateTime(2021, 05, 26, 16, 20, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual("trinta minutos atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornar20Segundos()
        {
            DateTime dataInformada = new DateTime(2021, 05, 26, 16, 50, 0);
            Data data = new Data(dataInformada);

            Assert.AreEqual("vinte segundos atrás", data.resultado);
        }
    }
}
