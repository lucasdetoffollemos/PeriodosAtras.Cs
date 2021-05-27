using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    public class ConversorData
    {
        public int TransformarDataEmDiasTotaisDecorridos(Data data)
        {
            return (data.dataAtual - data.dataInformada).Days;
        }

        public int TransformarDataEmAnosDecorridos(Data data)
        {
            data.restoAnosDecorridos = data.tempoTotalDecorridoDias % 365;
            return data.anosDecorridos = data.tempoTotalDecorridoDias / 365;
        }

        public int TransformarDataEmMesesDecorridos(Data data)
        {
            data.restoMesesDecorridos = data.restoAnosDecorridos % 30;
            return data.mesesDecorridos = data.restoAnosDecorridos / 30;
        }

        public int TransformarDataEmSemanasDecorridos(Data data)
        {
            data.restoSemanasDecorridas = data.restoMesesDecorridos % 7;
            return data.semanasDecorridas = data.restoMesesDecorridos / 7;
        }

        public int TransformarDataEmDiasDecorridos(Data data)
        {
            return data.diasDecorridos = data.restoSemanasDecorridas;
        }

        public string EscreveNumeroAteDoisDigitos(double valor)
        {
            Dictionary<char, string> unidades, teens, dezenas;
            GerarDictionaryNumerosPorExtenso(out unidades, out teens, out dezenas);

            string montagem = string.Empty;
            string strValor = valor.ToString("00");
            char a = Convert.ToChar(strValor.Substring(0, 1));
            char b = Convert.ToChar(strValor.Substring(1, 1));


            if (a == '1')
                montagem += teens[b] + " ";
            else
            {
                if (dezenas.ContainsKey(a))
                    montagem += dezenas[a] + ((b != '0') ? " e " : " ");

                if (unidades.ContainsKey(b))
                    montagem += unidades[b] + " ";
            }
            return montagem;
        }

        private static void GerarDictionaryNumerosPorExtenso(out Dictionary<char, string> unidades, out Dictionary<char, string> teens, out Dictionary<char, string> dezenas)
        {
            unidades = new Dictionary<char, string>();
            unidades.Add('1', "um");
            unidades.Add('2', "dois");
            unidades.Add('3', "três");
            unidades.Add('4', "quatro");
            unidades.Add('5', "cinco");
            unidades.Add('6', "seis");
            unidades.Add('7', "sete");
            unidades.Add('8', "oito");
            unidades.Add('9', "nove");

            teens = new Dictionary<char, string>();
            teens.Add('0', "dez");
            teens.Add('1', "onze");
            teens.Add('2', "doze");
            teens.Add('3', "treze");
            teens.Add('4', "quatorze");
            teens.Add('5', "quinze");
            teens.Add('6', "dezesseis");
            teens.Add('7', "dezessete");
            teens.Add('8', "dezoito");
            teens.Add('9', "dezenove");

            dezenas = new Dictionary<char, string>();
            dezenas.Add('2', "vinte");
            dezenas.Add('3', "trinta");
            dezenas.Add('4', "quarenta");
            dezenas.Add('5', "cinquenta");
            dezenas.Add('6', "sessenta");
            dezenas.Add('7', "setenta");
            dezenas.Add('8', "oitenta");
            dezenas.Add('9', "noventa");
        }
    }
}
