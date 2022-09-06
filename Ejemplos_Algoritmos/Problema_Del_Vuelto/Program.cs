// Ejemplo Problema de la moneda Greedy y Dinámico

void main() {

    int[] AvailableCoins = { 1, 2, 5, 10, 25, 50, 100, 200, 500, 100 };
    int input_data = 0;

    Console.Write("Ingrese monto a devolver >>> ");
    input_data = Convert.ToInt32(Console.ReadLine());

    Console.Write("\n\n>>>>>>>>>>----------<<<<<<<<<<\n\n");

    {
        Console.WriteLine("Método Voráz");
        Algorithms.CoinChangeG Problema_Greedy = new Algorithms.CoinChangeG( input_data, AvailableCoins );
        Problema_Greedy.print_dictionary();
    }

    Console.Write("\n\n>>>>>>>>>>----------<<<<<<<<<<\n\n");

    {
        Console.WriteLine("Método de Programación Dinámica");
        Algorithms.CoinChangeDP Problema_DP = new Algorithms.CoinChangeDP( input_data, AvailableCoins );
        Problema_DP.print_dictionary();
    }

    Console.WriteLine("Press any key to Exit...");
    Console.ReadKey();

}

main();