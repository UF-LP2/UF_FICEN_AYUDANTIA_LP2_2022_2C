namespace Ejemplo_Lista
{
    public partial class Form1 : Form
    {
        private List<int> lista;
        public Form1()
        {
            lista = new List<int>();
            InitializeComponent();
        }

        private void InsertarButton_Click(object sender, EventArgs e)
        {
            string value = "";
            int pos = 0;
            if (InputBox("Dialog Box", "Ingrese un dato", ref value, ref pos) == DialogResult.OK)
            {
                if (lista.Count == 0)
                    pos = 0;
                else if(lista.Count < pos)
                    pos = lista.Count;

                lista.Insert(pos, Int32.Parse(value));
                listBox1.Items.Insert(pos, value);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value, ref int pos)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Label label1 = new Label();
            NumericUpDown nud = new NumericUpDown();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            label1.Text = "Posición";

            buttonOk.Text = "Agregar";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            label1.SetBounds(36, 136, 372, 13);
            nud.SetBounds(36, 186, 700, 20);
            buttonOk.SetBounds(228, 300, 160, 60);
            buttonCancel.SetBounds(400, 300, 160, 60);

            label.AutoSize = true;
            label1.AutoSize = true;
            form.ClientSize = new Size(796, 450);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, label1, nud, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            pos = Convert.ToInt32(nud.Value);

            return dialogResult;
        }

        public static DialogResult InputBox2(string title, ref int pos)
        {
            Form form = new Form();
            Label label1 = new Label();
            NumericUpDown nud = new NumericUpDown();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label1.Text = "Posición";

            buttonOk.Text = "Agregar";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label1.SetBounds(36, 36, 372, 13);
            nud.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 300, 160, 60);
            buttonCancel.SetBounds(400, 300, 160, 60);

            label1.AutoSize = true;
            form.ClientSize = new Size(796, 450);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label1, nud, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            pos = Convert.ToInt32(nud.Value);

            return dialogResult;
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            int pos = 0;

            if (InputBox2("Dialog Box", ref pos) == DialogResult.OK)
            {

                if (listBox1.Items.Count > 0)
                {
                    if (lista.Count <= pos)
                        pos = lista.Count - 1;

                    label1.Text = "Dato removido: " + lista[pos];
                    lista.RemoveAt(pos);
                    listBox1.Items.RemoveAt(pos);
                }
            }
        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            lista.Sort();
            listBox1.Items.Clear();
            foreach(int a in lista)
                listBox1.Items.Add(a);
        }
    }
}