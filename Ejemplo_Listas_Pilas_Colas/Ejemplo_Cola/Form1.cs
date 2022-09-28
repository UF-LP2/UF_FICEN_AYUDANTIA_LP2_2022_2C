using System.Windows.Forms;

namespace Ejemplo_Cola
{
    public partial class Form1 : Form
    {
        Queue<int> cola;

        public Form1()
        {
            cola = new Queue<int>();
            InitializeComponent();
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "Agregar";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }

        //Enqueue Button
        private void button1_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Ingrese un dato", ref value) == DialogResult.OK)
            {
                cola.Enqueue(Int32.Parse(value));
                listBox1.Items.Add(value);
            }
        }

        //Dequeue Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                label1.Text = "Valor de Dequeue: " + cola.Dequeue().ToString();
                listBox1.Items.RemoveAt(0);
            }
        }
    }
}