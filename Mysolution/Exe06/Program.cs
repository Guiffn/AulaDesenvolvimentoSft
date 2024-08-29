


int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);
}
//Ordenar o vetor com bubble sort
// bool troca = false;
// do
// {
//     troca = false;

//     for (int i = 0; i < vetor.Length - 1; i++)
//     {
//         if (vetor[i] > vetor[i + 1])
//         {
//             //Troca
//             int aux = vetor[i];
//             vetor[i] = vetor[i + 1];
//             vetor[i + 1] = aux;
//             troca = true;
//         }
//     }
// // } while (troca);
//Criando uma função
// void bubbleSort(int[] vetor)
// {
//     bool troca;
//     troca=false;
//     do{


//         for(int i =0;i<vetor.Length;i++){
//             if(vetor[i]>vetor[i+1]){
//                 int aux = vetor[i];
//                 vetor[i]=vetor[i+1];
//                 vetor[i]=aux;
//                 troca =true

//             }
//         }
//     }while(troca);
// }
Array.sort(vetor);
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}
