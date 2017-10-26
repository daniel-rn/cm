namespace CORUJA
{
    partial class frmFrenteDeCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrenteDeCaixa));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.pbAdicionarTodosAoCarrinho = new System.Windows.Forms.PictureBox();
            this.pbExcluirTodos = new System.Windows.Forms.PictureBox();
            this.dgvRelacaoDeItens = new System.Windows.Forms.DataGridView();
            this.lblTotalDaCompra = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionarTodosAoCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluirTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacaoDeItens)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pbAdicionar);
            this.flowLayoutPanel1.Controls.Add(this.pbExcluir);
            this.flowLayoutPanel1.Controls.Add(this.pbAdicionarTodosAoCarrinho);
            this.flowLayoutPanel1.Controls.Add(this.pbExcluirTodos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(744, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(40, 472);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(3, 3);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(32, 32);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdicionar.TabIndex = 4;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.pbAdicionar_Click);
            // 
            // pbExcluir
            // 
            this.pbExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(3, 41);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(32, 32);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExcluir.TabIndex = 5;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.pbExcluir_Click);
            // 
            // pbAdicionarTodosAoCarrinho
            // 
            this.pbAdicionarTodosAoCarrinho.BackColor = System.Drawing.SystemColors.Control;
            this.pbAdicionarTodosAoCarrinho.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionarTodosAoCarrinho.Image")));
            this.pbAdicionarTodosAoCarrinho.Location = new System.Drawing.Point(3, 79);
            this.pbAdicionarTodosAoCarrinho.Name = "pbAdicionarTodosAoCarrinho";
            this.pbAdicionarTodosAoCarrinho.Size = new System.Drawing.Size(32, 32);
            this.pbAdicionarTodosAoCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdicionarTodosAoCarrinho.TabIndex = 6;
            this.pbAdicionarTodosAoCarrinho.TabStop = false;
            this.pbAdicionarTodosAoCarrinho.Click += new System.EventHandler(this.pbAdicionarTodosAoCarrinho_Click);
            // 
            // pbExcluirTodos
            // 
            this.pbExcluirTodos.BackColor = System.Drawing.SystemColors.Control;
            this.pbExcluirTodos.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluirTodos.Image")));
            this.pbExcluirTodos.Location = new System.Drawing.Point(3, 117);
            this.pbExcluirTodos.Name = "pbExcluirTodos";
            this.pbExcluirTodos.Size = new System.Drawing.Size(32, 32);
            this.pbExcluirTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExcluirTodos.TabIndex = 7;
            this.pbExcluirTodos.TabStop = false;
            this.pbExcluirTodos.Click += new System.EventHandler(this.pbExcluirTodos_Click);
            // 
            // dgvRelacaoDeItens
            // 
            this.dgvRelacaoDeItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelacaoDeItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRelacaoDeItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacaoDeItens.Location = new System.Drawing.Point(6, 73);
            this.dgvRelacaoDeItens.Name = "dgvRelacaoDeItens";
            this.dgvRelacaoDeItens.RowHeadersVisible = false;
            this.dgvRelacaoDeItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRelacaoDeItens.Size = new System.Drawing.Size(733, 234);
            this.dgvRelacaoDeItens.TabIndex = 4;
            // 
            // lblTotalDaCompra
            // 
            this.lblTotalDaCompra.AutoSize = true;
            this.lblTotalDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDaCompra.Location = new System.Drawing.Point(20, 387);
            this.lblTotalDaCompra.Name = "lblTotalDaCompra";
            this.lblTotalDaCompra.Size = new System.Drawing.Size(75, 31);
            this.lblTotalDaCompra.TabIndex = 5;
            this.lblTotalDaCompra.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(101, 387);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 31);
            this.txtTotal.TabIndex = 6;
            // 
            // frmFrenteDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotalDaCompra);
            this.Controls.Add(this.dgvRelacaoDeItens);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFrenteDeCaixa";
            this.Text = "frmFrenteDeCaixa";
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.dgvRelacaoDeItens, 0);
            this.Controls.SetChildIndex(this.lblTotalDaCompra, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionarTodosAoCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluirTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacaoDeItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvRelacaoDeItens;
        private System.Windows.Forms.Label lblTotalDaCompra;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.PictureBox pbAdicionarTodosAoCarrinho;
        private System.Windows.Forms.PictureBox pbExcluirTodos;
    }
}