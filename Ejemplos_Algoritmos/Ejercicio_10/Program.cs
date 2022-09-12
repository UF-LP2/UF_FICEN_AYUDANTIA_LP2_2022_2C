// Encontrar el número mayor de una lista por algoritmo DyV
// Chicos, pueden ver como es el algoritmo en la imagen adjunta
// Cualquier cosa consultenme.
// Saludos, Fran.

using System;

namespace Ejercicio10
{

    class MainClass
    {

        //Funcion vortice para llamar a la funcion recursiva mayor
        //Con los parametros de entrada inicio=1 y fin=largo del vector
        public static int mayor(int[] v)
        {
            //Llamada al Algoritmo Divide and Conquer con el inicio y el fin del arreglo y retorno del resultado
            return mayor(v, 1, v.Length);
        }

        //Función recursiva para obtener el número mas grande
        //Del subvector dado
        private static int mayor(int[] v, int inicio, int fin)
        {

            //Caso base Nro 1, que sea un unico elemento en la rama a analizar
            if (fin - inicio == 0)
                return v[inicio - 1];
            //Caso base Nro 2, que queden 2 elementos en la rama a analizar
            else if (fin - inicio == 1)
                if (v[inicio - 1] >= v[fin - 1])
                    return v[inicio - 1];
                else
                    return v[fin - 1];

            //Si no se cumple ninguno de los dos casos bases
            //Entonces vuelvo a dividir a la mitad
            //Obteniendo otra subrama izquierda y otra derecha
            int pivote = (fin - inicio) / 2 + inicio;
            int aux1 = mayor(v, inicio, pivote);
            int aux2 = mayor(v, pivote + 1, fin);

            //Cuando vuelvo de las llamadas anteriores
            //Comparo el resultado de ambas ramas y devuelvo el mayor
            if (aux1 >= aux2)
                return aux1;
            else return aux2;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 8, 1, 10, 40, 2, 31, 14, 38 };
            foreach (int a in arr)
                Console.Write(a + " ");
            Console.WriteLine("\nEl mayor es: "+mayor(arr));
        }
    }
}