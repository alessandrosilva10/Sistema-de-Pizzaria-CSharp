namespace Sistema_de_Pizzaria
{
    partial class Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisaPizza = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rbNomePizza = new System.Windows.Forms.RadioButton();
            this.rbIdPizza = new System.Windows.Forms.RadioButton();
            this.rbTodosPizza = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPesquisaBebida = new System.Windows.Forms.Label();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisaPizza);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.rbNomePizza);
            this.groupBox1.Controls.Add(this.rbIdPizza);
            this.groupBox1.Controls.Add(this.rbTodosPizza);
            this.groupBox1.Location = new System.Drawing.Point(23, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.ForeColor = System.Drawing.Color.Blue;
            this.lblPesquisa.Location = new System.Drawing.Point(3, 102);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(43, 13);
            this.lblPesquisa.TabIndex = 8;
            this.lblPesquisa.Text = "         ";
            this.lblPesquisa.Click += new System.EventHandler(this.lblPesquisa_Click);
            // 
            // txtPesquisaPizza
            // 
            this.txtPesquisaPizza.ForeColor = System.Drawing.Color.Blue;
            this.txtPesquisaPizza.Location = new System.Drawing.Point(6, 118);
            this.txtPesquisaPizza.Name = "txtPesquisaPizza";
            this.txtPesquisaPizza.Size = new System.Drawing.Size(162, 20);
            this.txtPesquisaPizza.TabIndex = 4;
            this.txtPesquisaPizza.TextChanged += new System.EventHandler(this.txtPesquisaPizza_TextChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Blue;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(53, 154);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 33);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rbNomePizza
            // 
            this.rbNomePizza.AutoSize = true;
            this.rbNomePizza.ForeColor = System.Drawing.Color.Blue;
            this.rbNomePizza.Location = new System.Drawing.Point(16, 65);
            this.rbNomePizza.Name = "rbNomePizza";
            this.rbNomePizza.Size = new System.Drawing.Size(53, 17);
            this.rbNomePizza.TabIndex = 2;
            this.rbNomePizza.Text = "Nome";
            this.rbNomePizza.UseVisualStyleBackColor = true;
            this.rbNomePizza.CheckedChanged += new System.EventHandler(this.rbNomePizza_CheckedChanged);
            // 
            // rbIdPizza
            // 
            this.rbIdPizza.AutoSize = true;
            this.rbIdPizza.ForeColor = System.Drawing.Color.Blue;
            this.rbIdPizza.Location = new System.Drawing.Point(16, 42);
            this.rbIdPizza.Name = "rbIdPizza";
            this.rbIdPizza.Size = new System.Drawing.Size(36, 17);
            this.rbIdPizza.TabIndex = 1;
            this.rbIdPizza.Text = "ID";
            this.rbIdPizza.UseVisualStyleBackColor = true;
            this.rbIdPizza.CheckedChanged += new System.EventHandler(this.rbIdPizza_CheckedChanged);
            // 
            // rbTodosPizza
            // 
            this.rbTodosPizza.AutoSize = true;
            this.rbTodosPizza.Checked = true;
            this.rbTodosPizza.ForeColor = System.Drawing.Color.Blue;
            this.rbTodosPizza.Location = new System.Drawing.Point(16, 19);
            this.rbTodosPizza.Name = "rbTodosPizza";
            this.rbTodosPizza.Size = new System.Drawing.Size(55, 17);
            this.rbTodosPizza.TabIndex = 0;
            this.rbTodosPizza.TabStop = true;
            this.rbTodosPizza.Text = "Todos";
            this.rbTodosPizza.UseVisualStyleBackColor = true;
            this.rbTodosPizza.CheckedChanged += new System.EventHandler(this.rbTodosPizza_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa de Pizzas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(303, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pesquisa de Bebidas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPesquisaBebida);
            this.groupBox2.Controls.Add(this.cbBebidas);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(324, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblPesquisaBebida
            // 
            this.lblPesquisaBebida.AutoSize = true;
            this.lblPesquisaBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaBebida.ForeColor = System.Drawing.Color.Blue;
            this.lblPesquisaBebida.Location = new System.Drawing.Point(15, 102);
            this.lblPesquisaBebida.Name = "lblPesquisaBebida";
            this.lblPesquisaBebida.Size = new System.Drawing.Size(43, 13);
            this.lblPesquisaBebida.TabIndex = 10;
            this.lblPesquisaBebida.Text = "         ";
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Items.AddRange(new object[] {
            "Todos"});
            this.cbBebidas.Location = new System.Drawing.Point(31, 65);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(121, 21);
            this.cbBebidas.TabIndex = 9;
            this.cbBebidas.Text = "Insira aqui";
            this.cbBebidas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(55, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sair";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(109, 337);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(354, 150);
            this.dgvPesquisa.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(156, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado da pesquisa";
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(577, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisaPizza;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rbNomePizza;
        private System.Windows.Forms.RadioButton rbIdPizza;
        private System.Windows.Forms.RadioButton rbTodosPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblPesquisaBebida;
        private System.Windows.Forms.Label label3;
    }
}