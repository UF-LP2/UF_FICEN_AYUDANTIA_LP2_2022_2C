// Encontrar el número mayor de una lista por algoritmo DyV
// Chicos, pueden ver como es el algoritmo en la imagen adjunta
// Cualquier cosa no duden consultar.
// Saludos, Fran.

using System;

namespace Ejercicio10
{

    class MainClass
    {
        // Funcion vortice para llamar a la funcion recursiva mayor
        // con los parametros de entrada inicio=1 y fin=largo del vector.
        public static int mayor(int[] v)
        {
            if (v.Length > 0)
                // Llamada al Algoritmo "Divide y Venceras". retorno del resultado.
                return mayor(v, 1, v.Length);
            else return 0;
        }

        // Función recursiva (DyV) para obtener el número mas grande del subvector dado.
        private static int mayor(int[] v, int inicio, int fin)
        {
            // Se evalúa en inicio-1 o fin-1 porque recuerden que las posiciones de los arreglos inician en 0 y terminan en largo-1
            // y nuestras posiciones de inicio y fin van desde 1 hasta el largo, esto es para poder realizar el cálculo de la mitad de forma correcta.
            
            // Caso base Nro 1, que sea un unico elemento en la rama a analizar.
            if (fin - inicio == 0)
                return v[inicio - 1];
            // Caso base Nro 2, que queden 2 elementos en la rama a analizar.
            else if (fin - inicio == 1)
                if (v[inicio - 1] >= v[fin - 1])
                    return v[inicio - 1];
                else
                    return v[fin - 1];

            // Si no se cumple ninguno de los dos casos bases
            // entonces vuelvo a dividir a la mitad
            // obteniendo otra subrama izquierda y otra derecha.
            int mitad = (fin - inicio) / 2 + inicio;
            int aux1 = mayor(v, inicio, mitad);
            int aux2 = mayor(v, mitad + 1, fin);

            // Cuando vuelvo de las llamadas anteriores
            // comparo el resultado de ambas ramas y devuelvo el mayor.
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