namespace con_ui;

partial class formAlgorithms
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
            this.split_Conenedor = new System.Windows.Forms.SplitContainer();
            this.btnRUN = new System.Windows.Forms.Button();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblAlgo = new System.Windows.Forms.Label();
            this.radiodynamicProg = new System.Windows.Forms.RadioButton();
            this.radioGreedy = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.split_Conenedor)).BeginInit();
            this.split_Conenedor.Panel1.SuspendLayout();
            this.split_Conenedor.Panel2.SuspendLayout();
            this.split_Conenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // split_Conenedor
            // 
            this.split_Conenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_Conenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Conenedor.Location = new System.Drawing.Point(0, 0);
            this.split_Conenedor.Name = "split_Conenedor";
            // 
            // split_Conenedor.Panel1
            // 
            this.split_Conenedor.Panel1.Controls.Add(this.btnRUN);
            this.split_Conenedor.Panel1.Controls.Add(this.lbl_Input);
            this.split_Conenedor.Panel1.Controls.Add(this.txtChange);
            this.split_Conenedor.Panel1.Controls.Add(this.lblAlgo);
            this.split_Conenedor.Panel1.Controls.Add(this.radiodynamicProg);
            this.split_Conenedor.Panel1.Controls.Add(this.radioGreedy);
            // 
            // split_Conenedor.Panel2
            // 
            this.split_Conenedor.Panel2.Controls.Add(this.treeView1);
            this.split_Conenedor.Size = new System.Drawing.Size(837, 407);
            this.split_Conenedor.SplitterDistance = 240;
            this.split_Conenedor.TabIndex = 0;
            // 
            // btnRUN
            // 
            this.btnRUN.Location = new System.Drawing.Point(89, 255);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(75, 50);
            this.btnRUN.TabIndex = 11;
            this.btnRUN.Text = "Correr";
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(47, 190);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(44, 15);
            this.lbl_Input.TabIndex = 10;
            this.lbl_Input.Text = "Vuelto:";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(47, 208);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(153, 23);
            this.txtChange.TabIndex = 8;
            // 
            // lblAlgo
            // 
            this.lblAlgo.AutoSize = true;
            this.lblAlgo.Location = new System.Drawing.Point(47, 104);
            this.lblAlgo.Name = "lblAlgo";
            this.lblAlgo.Size = new System.Drawing.Size(117, 15);
            this.lblAlgo.TabIndex = 7;
            this.lblAlgo.Text = "Algoritmo del Vuelto";
            // 
            // radiodynamicProg
            // 
            this.radiodynamicProg.AutoSize = true;
            this.radiodynamicProg.Location = new System.Drawing.Point(47, 147);
            this.radiodynamicProg.Name = "radiodynamicProg";
            this.radiodynamicProg.Size = new System.Drawing.Size(153, 19);
            this.radiodynamicProg.TabIndex = 6;
            this.radiodynamicProg.TabStop = true;
            this.radiodynamicProg.Text = "Programación Dinámica";
            this.radiodynamicProg.UseVisualStyleBackColor = true;
            // 
            // radioGreedy
            // 
            this.radioGreedy.AutoSize = true;
            this.radioGreedy.Location = new System.Drawing.Point(47, 122);
            this.radioGreedy.Name = "radioGreedy";
            this.radioGreedy.Size = new System.Drawing.Size(53, 19);
            this.radioGreedy.TabIndex = 5;
            this.radioGreedy.TabStop = true;
            this.radioGreedy.Text = "Voráz";
            this.radioGreedy.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(591, 405);
            this.treeView1.TabIndex = 0;
            // 
            // formAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 407);
            this.Controls.Add(this.split_Conenedor);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "formAlgorithms";
            this.Text = "Selector de Algoritmo";
            this.Load += new System.EventHandler(this.formAlgorithms_Load);
            this.split_Conenedor.Panel1.ResumeLayout(false);
            this.split_Conenedor.Panel1.PerformLayout();
            this.split_Conenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Conenedor)).EndInit();
            this.split_Conenedor.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private SplitContainer split_Conenedor;
    private Label lbl_Input;
    private TextBox txtChange;
    private Label lblAlgo;
    private RadioButton radiodynamicProg;
    private RadioButton radioGreedy;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button btnRUN;
    private TreeView treeView1;
}
