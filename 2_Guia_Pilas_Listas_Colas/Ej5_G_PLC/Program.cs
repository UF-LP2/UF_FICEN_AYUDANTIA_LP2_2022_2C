/*
 * 5. Simular la operación de n pilas operando simultáneamente y 
 * donde se saca y/o inserta elementos al azar en cualquiera de 
 * las pilas. Determinar cuál es la pila de mayor trabajo y cuál
 * es la pila de menos trabajo en un tiempo determinado de
 * operación.
 */


// Struct que contiene una pila y la cantidad de operaciones realizadas en la misma.
struct Pila
{
    public Stack<int> pila;
    public int cantOp;

    public Pila()
    {
        pila = new Stack<int>();
        cantOp = 0;
    }
}

public class Ej_5_G_PLC
{
    public static void Main()
    {
        List<Pila> lp = new List<Pila>();
        int N, pos, tiempo, pmin, pmax;
        Random rand = new Random(); // Generador de randoms
        DateTime dtAhora;           // Fecha actual
        DateTime dtFinal;           // Fecha con los segundos que debe ejecutar la simulación.

        Console.Write("Ingrese cantidad de pilas: ");
        N = Int32.Parse(Console.ReadLine());

        Console.Write("Ingrese tiempo de operación en segundos: ");
        tiempo = Int32.Parse(Console.ReadLine());

        // agregamos pilas a la lista
        for (int i = 0; i < N; i++) 
            lp.Add(new Pila());

        dtFinal = DateTime.Now.AddSeconds(tiempo);

        // Simulación de operaciones
        do
        {
            pos = rand.Next(0, N);

            if (rand.Next(0, 10) <= 5) 
                lp[pos].pila.Push(rand.Next(0, 10));
            else if (lp[pos].pila.Count > 0) 
                lp[pos].pila.Pop();

            // Esto se hace porque en las listas de structs no se puede modificar variables directamente por un tema de referencias.
            Pila aux = lp[pos];
            aux.cantOp++;
            lp[pos] = aux;

            Thread.Sleep(100);

            dtAhora = DateTime.Now;
        } while (dtAhora <= dtFinal);

        pmax = 0;
        pmin = 0;

        for (int i = 0; i < N; i++)
        {
            if (lp[pmax].cantOp < lp[i].cantOp)
            {
                pmax = i;
            }
            if (lp[pmin].cantOp > lp[i].cantOp)
            {
                pmin = i;
            }
            Console.WriteLine("Pila N° {0}: {1}", i + 1, lp[i].cantOp);
        }

        Console.WriteLine("La pila con mayor cantidad de operaciones es la N° {0} con {1} operaciones.", pmax + 1, lp[pmax].cantOp);
        Console.WriteLine("La pila con menor cantidad de operaciones es la N° {0} con {1} operaciones.", pmin + 1, lp[pmin].cantOp);
    }
}
