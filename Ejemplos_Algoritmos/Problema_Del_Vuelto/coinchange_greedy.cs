namespace Greedy_CoinChange {
    public class Greedy_CoinChange {
        public Dictionary<int, int> CoinExchange;
        public int[] Coins;
        public Greedy_CoinChange( int Exchange, int[] Coins ) {
            this.Coins = Coins;

            // Inicializamos el Diccionario
            this.CoinExchange = new Dictionary<int, int>();

            // Arrancamos el proceso obtener el vuelto
            this.greedy_method(Exchange);
        }

        // Método Greedy para que obtiene las monedas del vuelto
        void greedy_method(int Exchange) {
            if( Exchange <= 0 )
                return;
            
            int Coin_ = Change_finder(Exchange, 0);
            if ( Coin_ != 0 ) {
                
                if ( CoinExchange.ContainsKey(Coin_) )
                    CoinExchange[Coin_] += CoinExchange[Coin_];
                else
                    CoinExchange.Add(Coin_, 1);

                Exchange -= Coin_;

            }
            greedy_method(Exchange);
        }

        // Buscar de forma recursiva la moneda
        int Change_finder(int Value, int position) {
            if( ( position + 1 ) == Coins.Length )
                return 0;

            if ( Value >= Coins[position] ) 
                return Coins[position];
            
            return Change_finder(Value, position + 1); 
        }

        //
        public void print_dictionary() {

            int count_coins = 0;

            Console.WriteLine("Vuelto:");

            foreach ( KeyValuePair<int, int> Coin_ in CoinExchange ) {
                Console.WriteLine( "$" + Coin_.Key + " [" + Coin_.Value + "]" );

                count_coins += Coin_.Value;
            }

            Console.WriteLine( "Cantidad total de monedas: " + count_coins );
        }
    }
}