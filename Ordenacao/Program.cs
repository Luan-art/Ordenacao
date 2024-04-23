using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

int aux, max = 5;
int[] vetores = new int[max];
int[] vetorCopia = new int[max];
int[] vetorInverso = new int[max];

for(int i = 0; i < max; i++)
{
    vetores[i] = new Random().Next(0, max);
    vetorCopia[i] = vetores[i];
}

for (int i = 0; i < max; i++)
    Console.WriteLine("O Original:  " + vetores[i]);

Console.WriteLine();

for (int i = 0; i < max; i++)
{
    for (int j = i + 1; j < max; j++)
    {
        if (vetorCopia[j] < vetorCopia[i])
        {
            aux = vetorCopia[i];
            vetorCopia[i] = vetorCopia[j];
            vetorCopia[j] = aux;

        }
    }
}



for (int i = 1; i < max; i++)
{
    if (vetorCopia[i] == vetorCopia[i - 1])
    {
        for (int j = i; j < max - 1; j++)
        {
            vetorCopia[j] = vetorCopia[j + 1];
        }
        max--;
        i--;
    }
}

for (int i = 0; i < max; i++)
    Console.WriteLine("Do menor é:  " + vetorCopia[i]);

for (int i = 0; i < max; i++)
{
    vetorInverso[i] = vetorCopia[i];
}

for (int i = 0; i < max; i++)
{
    for (int j = i + 1; j < max; j++)
    {
        if (vetorInverso[j] > vetorInverso[i])
        {
            aux = vetorInverso[i];
            vetorInverso[i] = vetorInverso[j];
            vetorInverso[j] = aux;

        }
    }
}

Console.WriteLine("\n");

for (int i = 0; i < max; i++)
    Console.WriteLine("Do maior é:  " + vetorInverso[i]);







