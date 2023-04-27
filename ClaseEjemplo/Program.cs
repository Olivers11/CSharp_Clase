//clases

using ClaseEjemplo;




int[] numeros = new int[5];


for(int i = 0; i < 5; i++)
{
    Console.Write("Ingrese un numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}


int mayor = 0;
int menor = numeros[0];

for(int i = 0; i < 5; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }


    if (numeros[i]  < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine("El menor es: " + menor);




















