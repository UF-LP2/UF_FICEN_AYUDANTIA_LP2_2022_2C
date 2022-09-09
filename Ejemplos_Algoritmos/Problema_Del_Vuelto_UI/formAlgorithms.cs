namespace con_ui;

public partial class formAlgorithms : Form {
    
    public formAlgorithms() {
        InitializeComponent();
    }

    private void btnRUN_Click(object sender, EventArgs e)
    {
        if (txtChange.Text != string.Empty)
        {

            int[] coins_ = { 1, 2, 5, 10, 25, 50, 100, 200, 500, 1000 };

            if (radioGreedy.Checked)
            {

                //Algorithms.CoinChangeG Algo_G = new Algorithms.CoinChangeG( Convert.ToInt32(this.txtChange.Text), coins_ );

            }
            else
            {

                //Algorithms.CoinChangeDP Algo_DP = new Algorithms.CoinChangeDP( Convert.ToInt32(this.txtChange.Text), coins_ );


            }

        }
        else
        {
            MessageBox.Show("El campo del vuelto no puede estar vacio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void formAlgorithms_Load(object sender, EventArgs e)
    {
        this.treeView1.ShowPlusMinus = false;
        for(int i = 0; i < 5; i++ )
        {
            TreeNode nodo = new TreeNode("Iteración " + i);
            nodo.ExpandAll();
            for (int j = 0; j < 3; j++)
            {
                nodo.Nodes.Add(new TreeNode("Sub Node " + j));
            }
            this.treeView1.Nodes.Add(nodo);
        }

    }
}