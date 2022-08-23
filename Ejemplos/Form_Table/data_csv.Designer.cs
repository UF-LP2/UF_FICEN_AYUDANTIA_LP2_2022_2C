using System.ComponentModel;

namespace Demo_Form
{
    partial class data_csv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridView
            // 
            this.dgridView.AllowUserToAddRows = false;
            this.dgridView.AllowUserToDeleteRows = false;
            this.dgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridView.Location = new System.Drawing.Point(0, 0);
            this.dgridView.Name = "dgridView";
            this.dgridView.ReadOnly = true;
            this.dgridView.Size = new System.Drawing.Size(800, 450);
            this.dgridView.TabIndex = 0;
            // 
            // data_csv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgridView);
            this.Name = "data_csv";
            this.Text = "data_csv";
            ((System.ComponentModel.ISupportInitialize)(this.dgridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgridView;

        #endregion
    }
}