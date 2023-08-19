//creacion y declaracion de arreglo
string[] NombreCompleto = new string[4] {"Gerardo", "Enrique", "Menjivar", "Franco" };

//Mostrar valores almacenados en el arreglo
Console.WriteLine("Valores almacenados en el arreglo \n");
foreach (string i in NombreCompleto)
{
    Console.WriteLine(i);
}

//Almacenar la longitud del arreglo en una variable
int LongitudArreglo = NombreCompleto.Length;
Console.WriteLine($" \n La longitud del arreglo es: {LongitudArreglo} \n");

//Imprimir el tamaño del arreglo con sus valores
Console.WriteLine($" \n El tamaño del arreglo es: {LongitudArreglo} \n");
Console.WriteLine("Los valores en el arreglo son: \n");
for (int i= 0; i<LongitudArreglo; i++)
{
    Console.WriteLine($"La posicion {i}: {NombreCompleto[i]}");
}

