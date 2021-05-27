using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    public class Data
    {
        readonly ConversorHoras conversorHoras = new ConversorHoras();
        readonly ConversorData conversorData = new ConversorData();
        //public DateTime dataComHora = new DateTime(2021, 05, 26, 16, 50, 20);
        public DateTime dataInformada;
        public DateTime dataAtual = new DateTime(2021, 05, 26, 16, 50, 20);
        public int tempoTotalDecorridoDias;
        public int anosDecorridos, restoAnosDecorridos;
        public int mesesDecorridos, restoMesesDecorridos;
        public int semanasDecorridas, restoSemanasDecorridas;
        public int diasDecorridos;

        public int totalSegundos;
        public int horasDecorridas, restoHorasDecorridas;
        public int minutosDecorridos, restoMinutosDecorridos;
        public int segundosDecorridos;
        public string resultado = null;       

        public Data(DateTime d)
        {
            dataInformada = d;

            if (dataInformada > dataAtual)
            {
                resultado = "Data no Futuro";
            }
            else if(dataInformada.ToString("yyyy/MM/dd") == dataAtual.ToString("yyyy/MM/dd"))
            {
                SeparadorTempo();
                EscrevedorHoras();
            }
            else
            {
                SeparadorDatas();
                EscrevedorDatas();
                
            }               
            
        }

        private void SeparadorDatas()
        {
            tempoTotalDecorridoDias = conversorData.TransformarDataEmDiasTotaisDecorridos(this);
            anosDecorridos = conversorData.TransformarDataEmAnosDecorridos(this);
            mesesDecorridos = conversorData.TransformarDataEmMesesDecorridos(this);
            semanasDecorridas = conversorData.TransformarDataEmSemanasDecorridos(this);
            diasDecorridos = conversorData.TransformarDataEmDiasDecorridos(this);
        }

        private void SeparadorTempo()
        {
            totalSegundos = conversorHoras.TransformarHorasEmSegundosTotaisDecorridos(this);
            horasDecorridas = conversorHoras.TransformarSegundosTotaisEmHorasDecorridas(this);
            minutosDecorridos = conversorHoras.TransformarHorasEmMinutosDecorridos(this);
            segundosDecorridos = conversorHoras.TransformarMinutosEmSegundosDecorridos(this);
        }

        private void EscrevedorDatas()
        {
            resultado = conversorData.EscreveNumeroAteDoisDigitos(anosDecorridos);
            if (anosDecorridos != 0)
            {
                if (anosDecorridos == 1)
                    resultado += "ano ";
                else
                    resultado += "anos ";    
                
                if (mesesDecorridos != 0 || semanasDecorridas != 0 || diasDecorridos != 0)
                    resultado += "e ";          
            }            
            resultado += conversorData.EscreveNumeroAteDoisDigitos(mesesDecorridos);
            if (mesesDecorridos != 0)
            {
                if (mesesDecorridos == 1)
                    resultado += "mês ";
                else
                    resultado += "mêses ";

                if (semanasDecorridas != 0 || diasDecorridos != 0)
                    resultado += "e ";
            }
            resultado += conversorData.EscreveNumeroAteDoisDigitos(semanasDecorridas);
            if (semanasDecorridas != 0)
            {
                if (semanasDecorridas == 1)
                {
                    resultado += "semana ";
                    resultado = resultado.Replace("um semana", "uma semana");
                }
                else if (semanasDecorridas == 2)
                {
                    resultado += "semanas ";
                    resultado = resultado.Replace("dois semanas", "duas semanas");
                }
                else
                    resultado += "semanas ";

                if (diasDecorridos != 0)
                    resultado += "e ";
            }

            resultado += conversorData.EscreveNumeroAteDoisDigitos(diasDecorridos);
            if (diasDecorridos != 0)
            {
                if (diasDecorridos == 1)
                    resultado += "dia ";
                else
                    resultado += "dias ";
            }

            if (resultado != null && dataInformada.Date != dataAtual.Date)
                resultado += "atrás";
        }


        private void EscrevedorHoras()
        {
            resultado = conversorHoras.EscreveNumeroAteDoisDigitos(horasDecorridas);
            if (horasDecorridas != 0)
            {
                if (horasDecorridas == 1)
                    resultado += "hora ";
                else
                    resultado += "horas ";

                if (minutosDecorridos != 0 || segundosDecorridos != 0)
                    resultado += "e ";
            }
            resultado += conversorHoras.EscreveNumeroAteDoisDigitos(minutosDecorridos);
            if (minutosDecorridos != 0)
            {
                if (minutosDecorridos == 1)
                    resultado += "minuto ";
                else
                    resultado += "minutos ";

                if (segundosDecorridos != 0)
                    resultado += "e ";
            }

            resultado += conversorHoras.EscreveNumeroAteDoisDigitos(segundosDecorridos);
            if (segundosDecorridos != 0)
            {
                if (segundosDecorridos == 1)
                    resultado += "segundo ";
                else
                    resultado += "segundos ";
            }

            if (resultado != null && dataInformada != dataAtual)
                resultado += "atrás";
        }
    }
}
