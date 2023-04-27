
//clases

using ClaseEjemplo;



Console.Write("Ingrese el valor de N: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] cadenas = new string[N];


for(int i = 0; i < N; i++)
{
    Console.Write("ingrese la cadena: ");
    cadenas[i] = Console.ReadLine();
}


string mayor = "";
// ar = { "Oliver", "Mar", "Guatemala" }
for(int i = 0; i < N; i++)
{
    if (cadenas[i].Length > mayor.Length)
    {
        mayor = cadenas[i];
    }
}

Console.WriteLine("Cadena mas grande: " + mayor);




















