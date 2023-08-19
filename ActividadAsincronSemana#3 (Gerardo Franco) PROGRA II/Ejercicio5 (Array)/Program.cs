//Creacion de arreglo y declaracion
int[] Numeros = { 4, 10, 45, -67, -7, 25, 89, 64 };

//Datos almacenados en el arreglo sin modificar nada 
Console.WriteLine("Datos almacenados: \n");
foreach (int i in Numeros)
{
    Console.WriteLine(i);
}
Console.WriteLine();

//Datos almacenados en el arreglo utilizando la funcion reverse cambiandole el orden total a los datos
Console.WriteLine("Datos almacenados: (funcion Reverse)\n");
System.Array.Reverse(Numeros);
foreach (int j in Numeros)
{
    Console.WriteLine(j);
}
Console.WriteLine();

//Datos Almacenados en el arreglo aplicandole la funcion Stor ordenandolos de forma descendentes
Console.WriteLine("Datos almacenados: (funcion Sort)\n");
System.Array.Sort(Numeros);
foreach (int k in Numeros)
{
    Console.WriteLine(k);
}