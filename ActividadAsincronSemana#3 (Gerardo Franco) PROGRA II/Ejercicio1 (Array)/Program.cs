//Arreglo sin tamaño que puede almacenar enteros
int[] Arreglo1;

//Pedir al usuario cuantos datos va desear ingresar al arreglo
Console.Write("- ¿De que tamaño sera el array que desea ingresar? (Minimo 5 posiciones) ----> ");
int Tamaño = Convert.ToInt32(Console.ReadLine());

//Arreglo con tamaño según el dato que el usuario diga que va ingresar eso va almacenar
int[] Num = new int[Tamaño];

//Decicion que se tomara si el arreglo es mayor oh igual a 5
if (Tamaño >= 5)
{
    //Pedir al usuario los datos desde teclado
    for (int i = 0; i < Tamaño; i++)
    {
        Console.Write("\n Ingrese un numero ----> ");
        Num[i] = Convert.ToInt32(Console.ReadLine());
    }

    //Imprimir resultados
    for (int i = 0; i < Tamaño; i++) 
    {
        Console.WriteLine();
        Console.WriteLine(Num[i]);
    }
}
//Decicion que el arreglo no puede ser menor de 5 datos
else
{
    Console.WriteLine();
    Console.WriteLine("El tamaño del arreglo debe de ser igual o mayor a 5");
}
