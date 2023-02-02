int[] arreglo = new int[5];
string[] cadenas = { "Sandia", "Melon", "Uva", "Naranja" };
Console.WriteLine("Pedir datos:");
for (int indice = 0; indice < arreglo.Length; indice++)
{
    Console.WriteLine("Dame un valor:");
    arreglo[indice] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Mostrar los elementos enteros");
for (int indice = 0; indice < arreglo.Length; indice++)
{
    Console.WriteLine("El elemento {0} tiene un valor de {1}", indice, arreglo[indice]);
}

Console.WriteLine();
Console.WriteLine("Mostrar los elementos de manera inversa");
for (int indice = 1; indice < arreglo.Length + 1; indice++)
{
    Console.WriteLine("El elemento {0} tiene un valor de {1}", indice, arreglo[^indice]);
}

Console.WriteLine();
Console.WriteLine("Mostrar los elementos de cadenas");
for (int indice = 0; indice < cadenas.Length; indice++)
{
    Console.WriteLine(cadenas[indice]);
}

var rango = cadenas[0..3];
Console.WriteLine();
Console.WriteLine("Mostrar los elementos del rango de cadenas");
for (int indice = 0; indice < rango.Length; indice++)
{
    Console.WriteLine("El elemento {0} tiene un valor de {1}", indice, rango[indice]);
}