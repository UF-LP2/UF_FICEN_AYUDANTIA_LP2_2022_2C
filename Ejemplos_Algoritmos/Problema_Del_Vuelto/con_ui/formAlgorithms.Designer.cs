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
            this.radioGreedy = new System.Windows.Forms.RadioButton();
            this.radiodynamicProg = new System.Windows.Forms.RadioButton();
            this.lblAlgo = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioGreedy
            // 
            this.radioGreedy.AutoSize = true;
            this.radioGreedy.Location = new System.Drawing.Point(12, 50);
            this.radioGreedy.Name = "radioGreedy";
            this.radioGreedy.Size = new System.Drawing.Size(53, 19);
            this.radioGreedy.TabIndex = 0;
            this.radioGreedy.TabStop = true;
            this.radioGreedy.Text = "Voráz";
            this.radioGreedy.UseVisualStyleBackColor = true;
            // 
            // radiodynamicProg
            // 
            this.radiodynamicProg.AutoSize = true;
            this.radiodynamicProg.Location = new System.Drawing.Point(12, 84);
            this.radiodynamicProg.Name = "radiodynamicProg";
            this.radiodynamicProg.Size = new System.Drawing.Size(153, 19);
            this.radiodynamicProg.TabIndex = 1;
            this.radiodynamicProg.TabStop = true;
            this.radiodynamicProg.Text = "Programación Dinámica";
            this.radiodynamicProg.UseVisualStyleBackColor = true;
            // 
            // lblAlgo
            // 
            this.lblAlgo.AutoSize = true;
            this.lblAlgo.Location = new System.Drawing.Point(12, 18);
            this.lblAlgo.Name = "lblAlgo";
            this.lblAlgo.Size = new System.Drawing.Size(117, 15);
            this.lblAlgo.TabIndex = 2;
            this.lblAlgo.Text = "Algoritmo del Vuelto";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(12, 126);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(153, 23);
            this.txtChange.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(200, 126);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 45);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Correr";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // formAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 194);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblAlgo);
            this.Controls.Add(this.radiodynamicProg);
            this.Controls.Add(this.radioGreedy);
            this.Name = "formAlgorithms";
            this.Text = "Selector de Algoritmo";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private RadioButton radioGreedy;
    private RadioButton radiodynamicProg;
    private Label lblAlgo;
    private TextBox txtChange;
    private Button btnRun;
}
