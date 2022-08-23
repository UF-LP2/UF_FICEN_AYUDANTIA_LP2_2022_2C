using System;
using System.IO;
using System.Windows.Forms;
//using static Demo_Form.data_csv;

namespace Demo_Form {
    public partial class mainForm : Form {
        private data_csv csvFRM = null;
        private FileStream _file = null;
        public mainForm() {
            InitializeComponent();
        }

        private void recetarioDataSetBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void mainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'recetarioDataSet.Consulta_Receta' table. You can move, or remove it, as needed.
            //this.consulta_RecetaTableAdapter.Fill(this.recetarioDataSet.Consulta_Receta);
            // TODO: This line of code loads data into the 'recetarioDataSet.Receta' table. You can move, or remove it, as needed.
            //this.recetaTableAdapter.Fill(this.recetarioDataSet.Receta);
            // TODO: This line of code loads data into the 'recetarioDataSet.Fotos' table. You can move, or remove it, as needed.


        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ofdCSV = new System.Windows.Forms.OpenFileDialog();
            this.btnODFcsv = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdCSV
            // 
            this.ofdCSV.FileName = "ofdCSV";
            this.ofdCSV.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            // 
            // btnODFcsv
            // 
            this.btnODFcsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnODFcsv.Location = new System.Drawing.Point(147, 12);
            this.btnODFcsv.Name = "btnODFcsv";
            this.btnODFcsv.Size = new System.Drawing.Size(195, 43);
            this.btnODFcsv.TabIndex = 0;
            this.btnODFcsv.Text = "Abrir CSV";
            this.btnODFcsv.UseVisualStyleBackColor = true;
            this.btnODFcsv.Click += new System.EventHandler(this.btnODFcsv_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(12, 74);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(477, 144);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "Path Archivo: ...";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(367, 165);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(122, 53);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(501, 227);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnODFcsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnAbrir;

        private System.Windows.Forms.Button btnODFcsv;
        private System.Windows.Forms.Label lblFilePath;

        private System.Windows.Forms.OpenFileDialog ofdCSV;
        private void btnODFcsv_Click(object sender, EventArgs e) {
            if(this.ofdCSV.ShowDialog() == DialogResult.OK) {
                this._file = new FileStream(this.ofdCSV.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                this.lblFilePath.Text = "Path: " + this._file.Name;
            }
        }

        private void btnAbrir_Click_1(object sender, EventArgs e) {
            if (this._file != null) {
                this.csvFRM = new data_csv(this._file);
                this.csvFRM.Show();
            }
            else
                MessageBox.Show("No hay archivo seleccionado", "Error file path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
