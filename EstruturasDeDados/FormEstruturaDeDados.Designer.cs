
namespace EstruturasDeDados
{
    partial class frmEstruturaDeDados
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
            this.lblClose = new System.Windows.Forms.Label();
            this.btnVetor = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnPilha = new System.Windows.Forms.Button();
            this.btnFila = new System.Windows.Forms.Button();
            this.btnArvore = new System.Windows.Forms.Button();
            this.btnTabelaHash = new System.Windows.Forms.Button();
            this.btnGrafo = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(1290, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 29);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            // 
            // btnVetor
            // 
            this.btnVetor.BackColor = System.Drawing.Color.Black;
            this.btnVetor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVetor.ForeColor = System.Drawing.Color.White;
            this.btnVetor.Location = new System.Drawing.Point(511, 147);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(185, 57);
            this.btnVetor.TabIndex = 1;
            this.btnVetor.Text = "Vetor";
            this.btnVetor.UseVisualStyleBackColor = false;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.BackColor = System.Drawing.Color.White;
            this.btnMatriz.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMatriz.ForeColor = System.Drawing.Color.Black;
            this.btnMatriz.Location = new System.Drawing.Point(510, 210);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(186, 52);
            this.btnMatriz.TabIndex = 2;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = false;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.Blue;
            this.btnLista.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.Location = new System.Drawing.Point(511, 268);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(185, 51);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            // 
            // btnPilha
            // 
            this.btnPilha.BackColor = System.Drawing.Color.Purple;
            this.btnPilha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPilha.ForeColor = System.Drawing.Color.White;
            this.btnPilha.Location = new System.Drawing.Point(511, 325);
            this.btnPilha.Name = "btnPilha";
            this.btnPilha.Size = new System.Drawing.Size(185, 42);
            this.btnPilha.TabIndex = 4;
            this.btnPilha.Text = "Pilhas";
            this.btnPilha.UseVisualStyleBackColor = false;
            // 
            // btnFila
            // 
            this.btnFila.BackColor = System.Drawing.Color.Fuchsia;
            this.btnFila.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFila.ForeColor = System.Drawing.Color.White;
            this.btnFila.Location = new System.Drawing.Point(511, 373);
            this.btnFila.Name = "btnFila";
            this.btnFila.Size = new System.Drawing.Size(185, 39);
            this.btnFila.TabIndex = 5;
            this.btnFila.Text = "Fila";
            this.btnFila.UseVisualStyleBackColor = false;
            // 
            // btnArvore
            // 
            this.btnArvore.BackColor = System.Drawing.Color.Red;
            this.btnArvore.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArvore.ForeColor = System.Drawing.Color.White;
            this.btnArvore.Location = new System.Drawing.Point(511, 418);
            this.btnArvore.Name = "btnArvore";
            this.btnArvore.Size = new System.Drawing.Size(185, 50);
            this.btnArvore.TabIndex = 6;
            this.btnArvore.Text = "Árvore";
            this.btnArvore.UseVisualStyleBackColor = false;
            // 
            // btnTabelaHash
            // 
            this.btnTabelaHash.BackColor = System.Drawing.Color.Yellow;
            this.btnTabelaHash.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabelaHash.ForeColor = System.Drawing.Color.Black;
            this.btnTabelaHash.Location = new System.Drawing.Point(511, 474);
            this.btnTabelaHash.Name = "btnTabelaHash";
            this.btnTabelaHash.Size = new System.Drawing.Size(185, 47);
            this.btnTabelaHash.TabIndex = 7;
            this.btnTabelaHash.Text = "Tabela Hash";
            this.btnTabelaHash.UseVisualStyleBackColor = false;
            // 
            // btnGrafo
            // 
            this.btnGrafo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGrafo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGrafo.ForeColor = System.Drawing.Color.White;
            this.btnGrafo.Location = new System.Drawing.Point(511, 527);
            this.btnGrafo.Name = "btnGrafo";
            this.btnGrafo.Size = new System.Drawing.Size(185, 48);
            this.btnGrafo.TabIndex = 8;
            this.btnGrafo.Text = "Grafo";
            this.btnGrafo.UseVisualStyleBackColor = false;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(858, 268);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.Size = new System.Drawing.Size(416, 186);
            this.dgvDados.TabIndex = 9;
            // 
            // frmEstruturaDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1370, 624);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnGrafo);
            this.Controls.Add(this.btnTabelaHash);
            this.Controls.Add(this.btnArvore);
            this.Controls.Add(this.btnFila);
            this.Controls.Add(this.btnPilha);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnVetor);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstruturaDeDados";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnPilha;
        private System.Windows.Forms.Button btnFila;
        private System.Windows.Forms.Button btnArvore;
        private System.Windows.Forms.Button btnTabelaHash;
        private System.Windows.Forms.Button btnGrafo;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}