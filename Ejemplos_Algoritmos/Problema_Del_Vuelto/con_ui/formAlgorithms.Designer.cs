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
            this.lbl_Input = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblAlgo = new System.Windows.Forms.Label();
            this.radiodynamicProg = new System.Windows.Forms.RadioButton();
            this.radioGreedy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.split_Conenedor)).BeginInit();
            this.split_Conenedor.Panel1.SuspendLayout();
            this.split_Conenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // split_Conenedor
            // 
            this.split_Conenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Conenedor.Location = new System.Drawing.Point(0, 0);
            this.split_Conenedor.Name = "split_Conenedor";
            // 
            // split_Conenedor.Panel1
            // 
            this.split_Conenedor.Panel1.Controls.Add(this.lbl_Input);
            this.split_Conenedor.Panel1.Controls.Add(this.btnRun);
            this.split_Conenedor.Panel1.Controls.Add(this.txtChange);
            this.split_Conenedor.Panel1.Controls.Add(this.lblAlgo);
            this.split_Conenedor.Panel1.Controls.Add(this.radiodynamicProg);
            this.split_Conenedor.Panel1.Controls.Add(this.radioGreedy);
            this.split_Conenedor.Size = new System.Drawing.Size(743, 390);
            this.split_Conenedor.SplitterDistance = 247;
            this.split_Conenedor.TabIndex = 0;
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
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(89, 252);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 45);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Correr";
            this.btnRun.UseVisualStyleBackColor = true;
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
            // formAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 390);
            this.Controls.Add(this.split_Conenedor);
            this.MaximumSize = new System.Drawing.Size(759, 429);
            this.MinimumSize = new System.Drawing.Size(759, 429);
            this.Name = "formAlgorithms";
            this.Text = "Selector de Algoritmo";
            this.split_Conenedor.Panel1.ResumeLayout(false);
            this.split_Conenedor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Conenedor)).EndInit();
            this.split_Conenedor.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private SplitContainer split_Conenedor;
    private Label lbl_Input;
    private Button btnRun;
    private TextBox txtChange;
    private Label lblAlgo;
    private RadioButton radiodynamicProg;
    private RadioButton radioGreedy;
}
