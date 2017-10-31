namespace CORUJA
{
    partial class frmEstoqueAterrissagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controleGrid = new CONTROLES.ControleGrid();
            this.SuspendLayout();
            // 
            // controleGrid
            // 
            this.controleGrid.Location = new System.Drawing.Point(12, 91);
            this.controleGrid.Name = "controleGrid";
            this.controleGrid.Size = new System.Drawing.Size(628, 303);
            this.controleGrid.TabIndex = 3;
            // 
            // frmEstoqueAterrissagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.controleGrid);
            this.Name = "frmEstoqueAterrissagem";
            this.Text = "frmEstoqueAterrissagem";
            this.Controls.SetChildIndex(this.controleGrid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROLES.ControleGrid controleGrid;
    }
}