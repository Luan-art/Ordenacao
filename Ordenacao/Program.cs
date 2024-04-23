using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

int aux, max = 7;
int[] vetores = new int[max];
int[] vetorCopia = new int[max];


for(int i = 0; i < max; i++)
{
    vetores[i] = new Random().Next(-100, 100);
    vetorCopia[i] = vetores[i];

}
    
for (int i = 0; i < max; i++)
{
    
    for(int j = i + 1; j < max; j++)
    {
        if (vetorCopia[j] < vetorCopia[i])
        {
            aux = vetorCopia[i];
            vetorCopia[i] = vetorCopia[j];
            vetorCopia[j] = aux;

           
        }
    }

    
}


for (int i = 0; i < max; i++)
    Console.WriteLine("O menor é:  " + vetorCopia[i]);
    





