using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

int[] vetores = new int[5];
int[] vetorCopia = new int[5];
int aux;


for(int i = 0; i < 5; i++)
{
    vetores[i] = new Random().Next(0, 100);
}
for(int i = 0 ; i < 5; i++)
{
    vetorCopia[i] = vetores[i];
}

for (int i = 0; i < 5; i++)
{
    
    for(int j = i + 1; j < 5; j++)
    {
        if (vetorCopia[j] < vetorCopia[i])
        {
            aux = vetorCopia[i];
            vetorCopia[i] = vetorCopia[j];
            vetorCopia[j] = aux;

           
        }
    }

    
}


for (int i = 0; i < 5; i++)
    Console.WriteLine("O menor é:  " + vetorCopia[i]);
    





