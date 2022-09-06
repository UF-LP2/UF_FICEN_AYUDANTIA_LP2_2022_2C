// Ejemplo Problema de la moneda Greedy y Dinámico

class CoinChange {
    static void Main(string[] args) {

        int[] AvailableCoins = { 1, 2, 5, 10, 25, 50, 100, 200, 500, 1000 };

        {
            Console.WriteLine("Método Voráz");
            Algorithms.CoinChangeG Problema_Greedy = new Algorithms.CoinChangeG( Convert.ToInt32(args[0]), AvailableCoins );
            Problema_Greedy.print_dictionary();
        }

        Console.Write("\n\n>>>>>>>>>>----------<<<<<<<<<<\n\n");

        {
            Console.WriteLine("Método de Programación Dinámica");
            Algorithms.CoinChangeDP Problema_DP = new Algorithms.CoinChangeDP( Convert.ToInt32(args[0]), AvailableCoins );
            Problema_DP.print_dictionary();
        }

    }
}