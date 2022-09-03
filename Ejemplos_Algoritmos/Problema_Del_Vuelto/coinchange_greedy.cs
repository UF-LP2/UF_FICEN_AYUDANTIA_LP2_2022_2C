namespace Greedy_CoinChange {
    public class Greedy_CoinChange {
        public Dictionary<int, int> CoinExchange {
            get { return CoinExchange; }
            private set { CoinExchange = value; }
        }
        public int[] Coins {
            get { return Coins; }
            private set { Coins = value; }
            
        }
        Greedy_CoinChange(int Exchange) {
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
            if( Coin_ != 0 ) {
                Coins.
            }
                
            greedy_method(Exchange);
        }
        int Change_finder(int Value, int position) {
            if( ( position + 1 ) == Coins.Length )
                return 0;

            return Value <= Coins[position] ? Coins[position] : Change_finder(Value, position + 1); 
        }
    }
}