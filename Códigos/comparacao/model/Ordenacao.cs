using System.Collections.Generic;

namespace projeto.model
{
    class Ordenacao
    {
        public static void agitacao(List<int> lista)
        {
            bool houveTroca;
            int tmp;
            int ini = 0;
            int fim = lista.Count;
            int qtdComparacoes = 0, qtdTrocas = 0;  //avalia a complexidade ou o esforço
            do
            {
                houveTroca = false;
                for (int i = ini; i < fim - 1; i++)
                {
                    qtdComparacoes++;
                    if (lista[i] > lista[i + 1])
                    {
                        qtdTrocas++;
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
                if (!houveTroca)
                {
                    break;
                }
                fim--;
                houveTroca = false;
                for (int i = fim; i >= ini + 1; i--)
                {
                    qtdComparacoes++;
                    if (lista[i] < lista[i - 1])
                    {
                        qtdTrocas++;
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = tmp;
                    }
                }
                ini++;
            } while (houveTroca);
        }

        public static void bolha(List<int> lista)
        {
            bool houveTroca;
            int tmp;
            int qtdComparacoes = 0, qtdTrocas = 0;
            do
            {
                houveTroca = false;
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    qtdComparacoes++;
                    if (lista[i] > lista[i + 1])
                    {
                        qtdTrocas++;
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
            } while (houveTroca);
        }

        public static void pente(List<int> lista)
        {
            bool houveTroca;
            int tmp;
            int qtdComparacoes = 0, qtdTrocas = 0;
            int intervalo = lista.Count;
            do
            {
                intervalo = (int)(intervalo / 1.3);
                if (intervalo < 1)
                {
                    intervalo = 1;
                }
                houveTroca = false;
                for (int i = 0; i + intervalo < lista.Count; i++)
                {
                    qtdComparacoes++;
                    if (lista[i] > lista[i + intervalo])
                    {
                        qtdTrocas++;
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + intervalo];
                        lista[i + intervalo] = tmp;
                    }
                }
            } while (intervalo > 1 || houveTroca);
        }
    }
}
