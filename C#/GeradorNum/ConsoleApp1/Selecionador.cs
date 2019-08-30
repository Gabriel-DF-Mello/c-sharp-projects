﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorNum
{
    static class Selecionador
    {
        public static void SelectionSort(int[] v)
        {
            Console.WriteLine("Selection Sort");
            var relogio = new System.Diagnostics.Stopwatch();
            int pos_menor;
            int aux;
            int qtdCmp = 0, qtdTrc = 0;
            int n = v.Length;

            relogio.Start();
            for(int i = 0; i < n - 1; i += 1)
            {
                pos_menor = i;
                for (int j = (i + 1); j < n; j += 1)
                {
                    qtdCmp += 1;
                    if(v[j] < v[pos_menor])
                    {
                        pos_menor = j;
                    }
                }

                if(pos_menor != i)
                {
                    aux = v[i];
                    v[i] = v[pos_menor];
                    v[pos_menor] = aux;
                    qtdTrc += 1;
                }
            }
            relogio.Stop();
            Console.WriteLine("Tempo passado: " + relogio.Elapsed + "\nQuantidade de comparações: " + qtdCmp + "\nQuantidade de trocas: " + qtdTrc);
        }

        public static void InsertionSort(int[] v)
        {
            Console.WriteLine("Insertion Sort");
            var relogio = new System.Diagnostics.Stopwatch();
            int aux;
            int qtdCmp = 1, qtdTrc = 0;
            int i, j;
            int n = v.Length;

            relogio.Start();
            for (i = 1; i < n; i += 1)
            {
                aux = v[i];
                for (j = (i - 1); (j >= 0) && (aux < v[j]) ; j -= 1, qtdCmp += 1)
                {
                    v[j+1] = v[j];
                    qtdTrc += 1;
                }
                v[j + 1] = aux;
                qtdTrc += 1;
            }
            relogio.Stop();
            Console.WriteLine("Tempo passado: " + relogio.Elapsed + "\nQuantidade de comparações: " + qtdCmp + "\nQuantidade de trocas: " + qtdTrc);
        }

        public static void BubbleSort(int[] v)
        {
            Console.WriteLine("Bubble Sort");
            var relogio = new System.Diagnostics.Stopwatch();
            int n = v.Length;
            int aux;
            bool trocado = false;
            int qtdCmp = 0, qtdTrc = 0;

            relogio.Start();
            do
            {
                trocado = false;
                for (int i = 0; i < n - 1; i += 1)
                {
                    qtdCmp += 1;

                    if (v[i] > v[i + 1])
                    {
                        qtdTrc += 1;
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        trocado = true;
                    }
                }
                n -= 1;
            } while (trocado);

            relogio.Stop();
            Console.WriteLine("Tempo passado: " + relogio.Elapsed + "\nQuantidade de comparações: " + qtdCmp + "\nQuantidade de trocas: " + qtdTrc);
        }



        public static void CocktailSort(int[] v)
        {
            Console.WriteLine("Cocktail Sort");
            var relogio = new System.Diagnostics.Stopwatch();
            int stt = 0, end = v.Length;
            int aux;
            bool trocado = false;
            int qtdCmp = 0, qtdTrc = 0;

            relogio.Start();
            do
            {
                trocado = false;
                for (int i = stt; i < end - 1; i += 1)
                {
                    qtdCmp += 1;

                    if (v[i] > v[i + 1])
                    {
                        qtdTrc += 1;
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        trocado = true;
                    }
                }
                end -= 1;

                if (!trocado)
                {
                    relogio.Stop();
                    Console.WriteLine("Tempo passado: " + relogio.Elapsed + "\nQuantidade de comparações: " + qtdCmp + "\nQuantidade de trocas: " + qtdTrc);
                }

                for (int i = end; i > stt; i -= 1)
                {
                    qtdCmp += 1;

                    if (v[i] < v[i - 1])
                    {
                        qtdTrc += 1;
                        aux = v[i];
                        v[i] = v[i - 1];
                        v[i - 1] = aux;
                        trocado = true;
                    }
                }
                stt += 1;
            } while ((trocado)&&(stt<=end));

            relogio.Stop();
            Console.WriteLine("Tempo passado: " + relogio.Elapsed + "\nQuantidade de comparações: " + qtdCmp + "\nQuantidade de trocas: " + qtdTrc);
        }

        public static void CombSort(int[] v)
        {
            Console.WriteLine("Comb Sort");
            var relogio = new System.Diagnostics.Stopwatch();
            int distancia = (int) (v.Length / 1.3);
            int aux;
            bool trocado = false;
            int qtdCmp = 0, qtdTrc = 0;

            relogio.Start();
            do
            {
                distancia = (int) (distancia / 1.3);
                if (distancia < 1) distancia = 1;

                trocado = false;
                for (int i = 0; i + distancia < v.Length; i++)
                {
                    qtdCmp+=1;
                    if (v[i] > v[i + distancia])
                    {
                        aux = v[i];
                        v[i] = v[i + distancia];
                        v[i + distancia] = aux;
                        trocado = true;
                        qtdTrc+=1;
                    }
                }
            } while (distancia != 1 || trocado);
            relogio.Stop();
            Console.WriteLine("Tempo passado: " + relogio.Elapsed + "\nQuantidade de comparações: " + qtdCmp + "\nQuantidade de trocas: " + qtdTrc);
        }
    }
}
