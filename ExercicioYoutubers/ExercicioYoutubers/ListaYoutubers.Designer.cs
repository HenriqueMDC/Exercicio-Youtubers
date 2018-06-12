namespace ExercicioYoutubers
{
    partial class ListaYoutubers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeCanalColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePessoalColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApelidoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeVideoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeVisualizaçãoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCanalColumn1,
            this.NomePessoalColumn1,
            this.ApelidoColumn1,
            this.QuantidadeDeVideoColumn1,
            this.QuantidadeDeVisualizaçãoColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomeCanalColumn1
            // 
            this.NomeCanalColumn1.HeaderText = "Nome do Canal";
            this.NomeCanalColumn1.Name = "NomeCanalColumn1";
            this.NomeCanalColumn1.ReadOnly = true;
            // 
            // NomePessoalColumn1
            // 
            this.NomePessoalColumn1.HeaderText = "Nome Pessoal";
            this.NomePessoalColumn1.Name = "NomePessoalColumn1";
            this.NomePessoalColumn1.ReadOnly = true;
            // 
            // ApelidoColumn1
            // 
            this.ApelidoColumn1.HeaderText = "Apelido";
            this.ApelidoColumn1.Name = "ApelidoColumn1";
            this.ApelidoColumn1.ReadOnly = true;
            // 
            // QuantidadeDeVideoColumn1
            // 
            this.QuantidadeDeVideoColumn1.HeaderText = "Quantidade de Videos";
            this.QuantidadeDeVideoColumn1.Name = "QuantidadeDeVideoColumn1";
            this.QuantidadeDeVideoColumn1.ReadOnly = true;
            // 
            // QuantidadeDeVisualizaçãoColumn1
            // 
            this.QuantidadeDeVisualizaçãoColumn1.HeaderText = "Quantidade de Visualização";
            this.QuantidadeDeVisualizaçãoColumn1.Name = "QuantidadeDeVisualizaçãoColumn1";
            this.QuantidadeDeVisualizaçãoColumn1.ReadOnly = true;
            // 
            // ListaYoutubers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaYoutubers";
            this.Text = "ListaPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCanalColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePessoalColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApelidoColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeVideoColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeVisualizaçãoColumn1;
    }
}