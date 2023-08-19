using System.Threading.Tasks;

//Creacion y declaracion de arreglo
string[] Ejercicio3 = new string[10] {"Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"};

//Buscando posiciones de los datos que estan almacenados en el arreglo y luego imprimir cada uno 
Console.WriteLine("Datos almacenados en el arreglo: \n");
int LongitudTotal = Ejercicio3.Length;

for (int i= 0; i<LongitudTotal; i++)
{
    Console.WriteLine($"Posicion {i}: {Ejercicio3[i]}");
}

//Ordenar todos los datos almacenados de forma ascendente
Console.WriteLine();
Console.WriteLine("Datos almacenados en el arreglo de forma ordenada (ascendente): \n");
System.Array.Sort( Ejercicio3);
foreach (string j in Ejercicio3)
{
    Console.WriteLine(j);
}
