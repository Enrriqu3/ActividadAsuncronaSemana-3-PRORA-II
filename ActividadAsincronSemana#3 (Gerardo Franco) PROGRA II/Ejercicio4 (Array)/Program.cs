//Creacion y declaracion de arreglos
string[] Ejercicio4 = new string[10] { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

//Ordenando los datos almacenados de forma ascendente con la funcion Stor
System.Array.Sort(Ejercicio4);
Console.WriteLine("Palabras almacenadas: \n");
foreach (string e in Ejercicio4)
{
    Console.WriteLine(e);
}

//Mensaje de las palabras que se buscaran dentro de los datos almacenados en el arreglo
Console.WriteLine();
Console.WriteLine("Buscar las palabras sol, Dedo y casa: ");
Console.WriteLine();

//Creacion de variable para guardar lo que seria la posicion al buscarla con la funcion BinarySearch y luego imprimir la posicion en la que se encuentra dicha palabra a buscar
int posicion;
posicion = System.Array.BinarySearch(Ejercicio4, "Sol");
Console.WriteLine($"La palabra sol se encuenta en la posicion: {posicion}");
posicion = System.Array.BinarySearch(Ejercicio4, "Dedo");
Console.WriteLine($"La palabra Dedo se encuenta en la posicion: {posicion}");
posicion = System.Array.BinarySearch(Ejercicio4, "Casa");
Console.WriteLine($"La palabra Casa se encuenta en la posicion: {posicion}");
