namespace Algorithms {
    // G: Greedy
    public class CoinChangeG {
        Dictionary<int, int> Change_G;
        int[] Coins;
        public CoinChangeG( int Sum, int[] Coins ) {
            this.Coins = Coins;

            // Inicializamos el Diccionario
            this.Change_G = new Dictionary<int, int>();

            // Arrancamos el proceso obtener el vuelto
            this.greedy_method( Sum );
        }

        // Método Greedy para que obtiene las monedas del vuelto
        private void greedy_method( int Sum ) {
            if( Sum <= 0 )
                return;
            
            int Coin_ = Change_finder( Sum, 0 );
            if ( Coin_ != 0 ) {

                this.check_dictionary(Coin_);
                Sum -= Coin_;

            }
            greedy_method(Sum);
        }

        // Verifica si el key se encuentra o no dentro del diccionario, de no estar lo agrega
        private void check_dictionary( int Coin_ ) {

            if( this.Change_G.ContainsKey(Coin_) ) {
                this.Change_G[Coin_]++;
                return;
            }
            this.Change_G.Add( Coin_, 1 );

        }

        // Buscar de forma recursiva la moneda
        private int Change_finder( int Value, int position ) {
            if( ( position + 1 ) == Coins.Length )
                return 0;

            if ( Value >= Coins[position] ) 
                return Coins[position];
            
            return Change_finder( Value, position + 1 ); 
        }

        //
        public void print_dictionary() {

            int count_coins = 0;
            Console.Write( "Vuelto: " );

            foreach ( KeyValuePair<int, int> Coin_ in Change_G ) {
                Console.Write( "$" + Coin_.Key + " [" + Coin_.Value + "]" );
                count_coins += Coin_.Value;
            }

            Console.Write( " >>> Cantidad total de monedas: " + count_coins );
        }
    }

    // DP: Dynamic Programming
    public class CoinChangeDP {
        private List<int[]> Change_DP = new List<int[]>();
        private List<Dictionary<int, int>> Dict_DP = new List<Dictionary<int, int>>();
        private int Count_Options = 0;
        public CoinChangeDP( int Sum, int[] Coins ) {
            
            int[] Change_Coins = { };

            // Arrancamos el proceso obtener el vuelto
            this.Count_Options = this.methodDP( Coins, Coins.Length, Sum, Change_Coins, Sum );

            // Transformamos el listado de array a diccionario
            this.Array_to_Dictionary();

            this.Change_DP.Clear();

        }
        private int methodDP( int[] CoinChange_, int n_, int Sum_, int[] Change_, int ctrl_ ) {

            if ( Sum_ != ctrl_ ) {
                Change_ = Change_.Append(CoinChange_[n_ - 1]).ToArray();
                ctrl_ = Sum_;
            }

            if ( Sum_ == 0 ) {
                this.Change_DP.Add(Change_);
                return 1;
            }

            if ( Sum_ < 0 )
                return 0;

            if ( n_ <= 0 )
                return 0;

            return this.methodDP( CoinChange_, n_ - 1, Sum_, Change_, ctrl_ ) + this.methodDP( CoinChange_, n_, Sum_ - CoinChange_[n_ - 1], Change_, ctrl_ ); 
        }

        // Crea un sub array basado en el array original
        private int[] SubArray(int[] array_, int index_, int length_ ) {

            int[] aux = new int[length_];
            Array.Copy( array_, index_, aux, 0, length_ );
            return aux;

        }

        // Convertir arrays to diccionario
        private void Array_to_Dictionary() {

            foreach ( int[] values_ in this.Change_DP ) {

                Dictionary<int, int> aux_ = new Dictionary<int, int>();

                foreach( int node in values_ ) {

                    check_dictionary( node, ref aux_ );

                }

                this.Dict_DP.Add(aux_);

            }

        }

        // Verifica si el key se encuentra o no dentro del diccionario, de no estar lo agrega
        private void check_dictionary( int Coin_, ref Dictionary<int, int> Dict_aux ) {

            if( Dict_aux.ContainsKey(Coin_) ) {
                Dict_aux[Coin_]++;
                return;
            }

            Dict_aux.Add( Coin_, 1 );

        }

        // Imprimir el lista de posibles vueltos
        public void print_dictionary() {

            int i = 1;

            foreach ( Dictionary<int, int> node in this.Dict_DP ) {

                int count_coins = 0;
                Console.Write("Iteration: {0} de {1} :: ", i, this.Count_Options);

                foreach ( KeyValuePair<int, int> value_ in node ) {

                    Console.Write("${0} [{1}] ", value_.Key, value_.Value);
                    count_coins += value_.Value;

                }

                Console.WriteLine("");
                i++;

            }

        }
    }
}