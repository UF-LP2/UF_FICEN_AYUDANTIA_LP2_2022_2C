using System.Data;
using System.IO;

namespace Demo_Form {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private System.Windows.Forms.StatusStrip sttsBar;
        private System.Windows.Forms.ToolStripStatusLabel lblPath;
        private System.Windows.Forms.ToolStrip stripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnSaveCSV;
        private System.Windows.Forms.DataGridView gridCSV;
    }
}