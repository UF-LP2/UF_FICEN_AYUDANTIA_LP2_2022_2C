namespace Algorithms {
    // G: Greedy
    public class CoinChangeG {
        int[] Coins;
        public CoinChangeG( int Sum, int[] Coins ) {
            this.Coins = Coins;

            // Arrancamos el proceso obtener el vuelto
            this.greedy_method( Sum );
        }

        // Método Greedy para que obtiene las monedas del vuelto
        private void greedy_method( int Sum ) {
            if( Sum <= 0 )
                return;
            
            int Coin_ = Change_finder( Sum, 0 );
            if ( Coin_ != 0 ) {

                //this.check_dictionary(Coin_);
                Sum -= Coin_;

            }

            greedy_method(Sum);
        }

        // Buscar de forma recursiva la moneda
        private int Change_finder( int Value, int position ) {
            if( ( position + 1 ) == Coins.Length )
                return 0;

            if ( Value >= Coins[position] ) 
                return Coins[position];
            
            return Change_finder( Value, position + 1 ); 
        }

    }

    // DP: Dynamic Programming
    public class CoinChangeDP {
        private int Count_Options = 0;
        public CoinChangeDP( int Sum, int[] Coins, TreeView tree_ ) {
            
            int[] Change_Coins = { };

            TreeNode Node_ = new TreeNode();
            tree_.Nodes.Add(Node_);
            
            // Arrancamos el proceso obtener el vuelto
            this.Count_Options = this.methodDP( Coins, Coins.Length, Sum, Change_Coins, Sum, Node_ );

            tree_.Update();

        }
        private int methodDP( int[] CoinChange_, int n_, int Sum_, int[] Change_, int ctrl_, TreeNode Node_ ) {

            TreeNode NextNode_ = new TreeNode();

            if (Sum_ != ctrl_)
                Change_ = Change_.Append(CoinChange_[n_ - 1]).ToArray();

            if ( Sum_ == 0 )
                return 1;

            if ( Sum_ < 0 )
                return 0;

            if ( n_ <= 0 )
                return 0;

            ctrl_ = Sum_;

            string tree_string = Name_string(CoinChange_, Sum_);
            Node_.Text = tree_string.ToString();

            Node_.Nodes.Add(NextNode_);

            return this.methodDP( CoinChange_, n_ - 1, Sum_, Change_, ctrl_, NextNode_ ) + this.methodDP( CoinChange_, n_, Sum_ - CoinChange_[n_ - 1], Change_, ctrl_, NextNode_); 
        }

        private string Name_string( int[] CoinsVector, int Sum_ ) {

            string aux = "";

            aux += "{ " ;

            for ( int i = 0; i < CoinsVector.Length; i++ )
                aux += CoinsVector[i] + " ";

            aux += "} - " + Sum_;

            return aux;

        } 

        // Crea un sub array basado en el array original
        private int[] SubArray(int[] array_, int index_, int length_ ) {

            int[] aux = new int[length_];
            Array.Copy( array_, index_, aux, 0, length_ );
            return aux;

        }

    }
}