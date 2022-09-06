namespace con_ui;

public partial class formAlgorithms : Form {
    public formAlgorithms() {
        InitializeComponent();
    }

    private void btnRun_Click(object sender, EventArgs e) {
        if ( this.txtChange.Text != String.Empty) {

            int[] coins_ = { 1, 2, 5, 10, 25, 50, 100, 200, 500, 1000 };

            if (this.radioGreedy.Checked) {

                Algorithms.CoinChangeG Algo_G = new Algorithms.CoinChangeG( Convert.ToInt32(this.txtChange.Text), coins_ );

            } else {



            }

        } else {
            MessageBox.Show("El campo del vuelto no puede estar vacio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
