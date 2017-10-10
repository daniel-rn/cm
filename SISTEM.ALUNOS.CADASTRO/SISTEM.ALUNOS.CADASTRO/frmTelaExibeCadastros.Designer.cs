namespace CORUJA
{
    partial class frmTelaExibeCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaExibeCadastros));
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDgv.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.panel2);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgv.Location = new System.Drawing.Point(0, 67);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(784, 472);
            this.pnlDgv.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 342);
            this.panel2.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 23);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(679, 319);
            this.grid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALUNOS";
            // 
            // lbData
            // 
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(118, 17);
            this.lbData.Text = "toolStripStatusLabel1";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TelaExibeCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaExibeCadastros";
            this.Text = "TelaExibeCadastros";
            this.Load += new System.EventHandler(this.TelaExibeCadastros_Load);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.pnlDgv.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel lbData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid;
    }
}