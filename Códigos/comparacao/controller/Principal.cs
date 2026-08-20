using System.Collections.Generic;
using System.Diagnostics;
using projeto.model;
using ViewUtil = projeto.view.Util;

namespace projeto.controller
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            List<int> listaAgitacao = new List<int>();
            List<int> listaSort = new List<int>();
            List<int> listaBolha = new List<int>();
            List<int> listaPente = new List<int>();

            Util.popular(listaAgitacao, 100000);
            Util.popular(listaSort, 100000);
            Util.popular(listaBolha, 100000);
            Util.popular(listaPente, 100000);

            Stopwatch sw = new Stopwatch();

            sw.Start();
            Ordenacao.agitacao(listaAgitacao);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por agitacao");

            sw.Reset();
            sw.Start();
            listaSort.Sort();
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por sort nativo");
            sw.Reset();

            sw.Start();
            Ordenacao.bolha(listaBolha);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por bolha");
            sw.Reset();

            sw.Start();
            Ordenacao.pente(listaPente);
            sw.Stop();
            ViewUtil.exibirTempo(sw, "Ordenacao por pente");
            sw.Reset();

            //ViewUtil.exibir(listaAgitacao);
        }
    }
}
