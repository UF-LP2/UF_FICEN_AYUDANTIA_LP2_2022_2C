// Ejemplo Problema de la moneda Greedy y Dinámico

class CoinChange {
    static void Main(string[] args) {

        int[] AvailableCoins = { 1, 2, 5, 10, 25, 50, 100, 200, 500, 1000 };

        if ( args.Length < 1 ) {

            // Método Voráz
            Algorithms.CoinChangeG Problema_Greedy = new Algorithms.CoinChangeG( 3, AvailableCoins );
            Problema_Greedy.print_dictionary();

            // Método de Programación Dinámica
            Algorithms.CoinChangeDP Problema_DP = new Algorithms.CoinChangeDP( 3, AvailableCoins );
            Problema_DP.print_dictionary();

        } else {

            if ( args.Length < 2 ) {

                // Método Voráz
                Algorithms.CoinChangeG Problema_Greedy = new Algorithms.CoinChangeG( Convert.ToInt32(args[0]), AvailableCoins );
                Problema_Greedy.print_dictionary();

            } else {

                // Método de Programación Dinámica
                Algorithms.CoinChangeDP Problema_DP = new Algorithms.CoinChangeDP( Convert.ToInt32(args[0]), AvailableCoins );
                Problema_DP.print_dictionary();

            }

        }

    }
    
}