namespace con_ui;

public partial class formAlgorithms : Form {
    
    public formAlgorithms() {
        InitializeComponent();
    }

    private void btnRUN_Click(object sender, EventArgs e)
    {
        if (txtChange.Text != string.Empty) {
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ExpandAll();

            if ( this.treeView1.Nodes.Count > 0 )
                this.treeView1.Nodes.Clear();

            int[] coins_ = { 1, 2, 5, 10, 25, 50, 100, 200, 500, 1000 };

            if (radioGreedy.Checked) {

                Algorithms.CoinChangeG Algo_G = new Algorithms.CoinChangeG( Convert.ToInt32(this.txtChange.Text), coins_ );

            } else {

                Algorithms.CoinChangeDP Algo_DP = new Algorithms.CoinChangeDP( Convert.ToInt32(this.txtChange.Text), coins_, this.treeView1 );

            }

        }
        else {
            MessageBox.Show("El campo del vuelto no puede estar vacio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void formAlgorithms_Load(object sender, EventArgs e) {
        
    }
}