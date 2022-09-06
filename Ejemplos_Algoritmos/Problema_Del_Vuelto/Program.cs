// Ejemplo Problema de la moneda Greedy y Dinámico

void main() {

    int[] AvailableCoins = { 1, 2, 3 };

    {
        Algorithms.CoinChangeG Problema_Greedy = new Algorithms.CoinChangeG( 5, AvailableCoins );
        Problema_Greedy.print_dictionary();
    }

    {
        Algorithms.CoinChangeDP Problema_DP = new Algorithms.CoinChangeDP( 5, AvailableCoins );
        Problema_DP.print_dictionary();
    }

    Console.WriteLine("Press any key to Exit...");
    Console.ReadKey();

}

main();