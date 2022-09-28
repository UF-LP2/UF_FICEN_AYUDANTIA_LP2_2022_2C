namespace Ejemplo_Lista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.OrdenarButton = new System.Windows.Forms.Button();
            this.QuitarButton = new System.Windows.Forms.Button();
            this.InsertarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarButton);
            this.splitContainer1.Panel1.Controls.Add(this.QuitarButton);
            this.splitContainer1.Panel1.Controls.Add(this.InsertarButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(622, 321);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 66);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(206, 44);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // OrdenarButton
            // 
            this.OrdenarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdenarButton.Location = new System.Drawing.Point(0, 44);
            this.OrdenarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrdenarButton.Name = "OrdenarButton";
            this.OrdenarButton.Size = new System.Drawing.Size(206, 22);
            this.OrdenarButton.TabIndex = 2;
            this.OrdenarButton.Text = "Ordenar";
            this.OrdenarButton.UseVisualStyleBackColor = true;
            this.OrdenarButton.Click += new System.EventHandler(this.OrdenarButton_Click);
            // 
            // QuitarButton
            // 
            this.QuitarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuitarButton.Location = new System.Drawing.Point(0, 22);
            this.QuitarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuitarButton.Name = "QuitarButton";
            this.QuitarButton.Size = new System.Drawing.Size(206, 22);
            this.QuitarButton.TabIndex = 1;
            this.QuitarButton.Text = "Quitar";
            this.QuitarButton.UseVisualStyleBackColor = true;
            this.QuitarButton.Click += new System.EventHandler(this.QuitarButton_Click);
            // 
            // InsertarButton
            // 
            this.InsertarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertarButton.Location = new System.Drawing.Point(0, 0);
            this.InsertarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InsertarButton.Name = "InsertarButton";
            this.InsertarButton.Size = new System.Drawing.Size(206, 22);
            this.InsertarButton.TabIndex = 0;
            this.InsertarButton.Text = "Insertar";
            this.InsertarButton.UseVisualStyleBackColor = true;
            this.InsertarButton.Click += new System.EventHandler(this.InsertarButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 321);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 321);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Ejemplo Lista";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Splitter splitter1;
        private Button OrdenarButton;
        private Button QuitarButton;
        private Button InsertarButton;
        private ListBox listBox1;
    }
}