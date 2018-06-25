namespace Sistema_de_Pizzaria
{
    partial class Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizza));
            this.dgvPizza1 = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPizza = new System.Windows.Forms.TextBox();
            this.txtNomePizza = new System.Windows.Forms.TextBox();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.lblNomePizza = new System.Windows.Forms.Label();
            this.grpCadastroPizzas = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSairCadastroPizza = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.brnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdDeletar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txTipoEditar = new System.Windows.Forms.TextBox();
            this.txtIdEditar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza1)).BeginInit();
            this.grpCadastroPizzas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPizza1
            // 
            this.dgvPizza1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizza1.Location = new System.Drawing.Point(88, 55);
            this.dgvPizza1.Name = "dgvPizza1";
            this.dgvPizza1.Size = new System.Drawing.Size(359, 211);
            this.dgvPizza1.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(9, 171);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 33);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo da Pizza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor R$";
            // 
            // txtIdPizza
            // 
            this.txtIdPizza.Enabled = false;
            this.txtIdPizza.Location = new System.Drawing.Point(79, 67);
            this.txtIdPizza.Name = "txtIdPizza";
            this.txtIdPizza.Size = new System.Drawing.Size(43, 20);
            this.txtIdPizza.TabIndex = 5;
            this.txtIdPizza.TextChanged += new System.EventHandler(this.txtIdPizza_TextChanged);
            // 
            // txtNomePizza
            // 
            this.txtNomePizza.Location = new System.Drawing.Point(79, 93);
            this.txtNomePizza.Name = "txtNomePizza";
            this.txtNomePizza.Size = new System.Drawing.Size(100, 20);
            this.txtNomePizza.TabIndex = 6;
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(79, 119);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(100, 20);
            this.txtValorPizza.TabIndex = 7;
            // 
            // lblNomePizza
            // 
            this.lblNomePizza.AutoSize = true;
            this.lblNomePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePizza.ForeColor = System.Drawing.Color.Blue;
            this.lblNomePizza.Location = new System.Drawing.Point(60, 9);
            this.lblNomePizza.Name = "lblNomePizza";
            this.lblNomePizza.Size = new System.Drawing.Size(412, 25);
            this.lblNomePizza.TabIndex = 8;
            this.lblNomePizza.Text = "PIZZAS CADASTRADAS NO SISTEMA";
            this.lblNomePizza.Click += new System.EventHandler(this.lblNomePizza_Click);
            // 
            // grpCadastroPizzas
            // 
            this.grpCadastroPizzas.Controls.Add(this.label8);
            this.grpCadastroPizzas.Controls.Add(this.btnSairCadastroPizza);
            this.grpCadastroPizzas.Controls.Add(this.label3);
            this.grpCadastroPizzas.Controls.Add(this.label1);
            this.grpCadastroPizzas.Controls.Add(this.txtValorPizza);
            this.grpCadastroPizzas.Controls.Add(this.label2);
            this.grpCadastroPizzas.Controls.Add(this.txtNomePizza);
            this.grpCadastroPizzas.Controls.Add(this.btnGravar);
            this.grpCadastroPizzas.Controls.Add(this.txtIdPizza);
            this.grpCadastroPizzas.ForeColor = System.Drawing.Color.Blue;
            this.grpCadastroPizzas.Location = new System.Drawing.Point(23, 292);
            this.grpCadastroPizzas.Name = "grpCadastroPizzas";
            this.grpCadastroPizzas.Size = new System.Drawing.Size(200, 227);
            this.grpCadastroPizzas.TabIndex = 9;
            this.grpCadastroPizzas.TabStop = false;
            this.grpCadastroPizzas.Enter += new System.EventHandler(this.grpCadastroPizzas_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cadastro no Sistema";
            // 
            // btnSairCadastroPizza
            // 
            this.btnSairCadastroPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCadastroPizza.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCadastroPizza.Image")));
            this.btnSairCadastroPizza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairCadastroPizza.Location = new System.Drawing.Point(104, 171);
            this.btnSairCadastroPizza.Name = "btnSairCadastroPizza";
            this.btnSairCadastroPizza.Size = new System.Drawing.Size(75, 33);
            this.btnSairCadastroPizza.TabIndex = 12;
            this.btnSairCadastroPizza.Text = "Sair";
            this.btnSairCadastroPizza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairCadastroPizza.UseVisualStyleBackColor = true;
            this.btnSairCadastroPizza.Click += new System.EventHandler(this.btnSairCadastroPizza_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(59, 171);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 33);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // brnRemover
            // 
            this.brnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRemover.Image = ((System.Drawing.Image)(resources.GetObject("brnRemover.Image")));
            this.brnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnRemover.Location = new System.Drawing.Point(27, 88);
            this.brnRemover.Name = "brnRemover";
            this.brnRemover.Size = new System.Drawing.Size(90, 33);
            this.brnRemover.TabIndex = 11;
            this.brnRemover.Text = "Remover";
            this.brnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnRemover.UseVisualStyleBackColor = true;
            this.brnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIdDeletar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.brnRemover);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(229, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Deletar do Sistema";
            // 
            // txtIdDeletar
            // 
            this.txtIdDeletar.Location = new System.Drawing.Point(37, 40);
            this.txtIdDeletar.Name = "txtIdDeletar";
            this.txtIdDeletar.Size = new System.Drawing.Size(69, 20);
            this.txtIdDeletar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.label9);
            this.gbEditar.Controls.Add(this.label7);
            this.gbEditar.Controls.Add(this.label5);
            this.gbEditar.Controls.Add(this.txtValorEditar);
            this.gbEditar.Controls.Add(this.label6);
            this.gbEditar.Controls.Add(this.txTipoEditar);
            this.gbEditar.Controls.Add(this.txtIdEditar);
            this.gbEditar.Controls.Add(this.btnEditar);
            this.gbEditar.ForeColor = System.Drawing.Color.Blue;
            this.gbEditar.Location = new System.Drawing.Point(368, 292);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(200, 227);
            this.gbEditar.TabIndex = 13;
            this.gbEditar.TabStop = false;
            this.gbEditar.Enter += new System.EventHandler(this.gbEditar_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Editar no Sistema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor R$";
            // 
            // txtValorEditar
            // 
            this.txtValorEditar.Location = new System.Drawing.Point(91, 116);
            this.txtValorEditar.Name = "txtValorEditar";
            this.txtValorEditar.Size = new System.Drawing.Size(100, 20);
            this.txtValorEditar.TabIndex = 15;
            this.txtValorEditar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo da Pizza";
            // 
            // txTipoEditar
            // 
            this.txTipoEditar.Location = new System.Drawing.Point(91, 90);
            this.txTipoEditar.Name = "txTipoEditar";
            this.txTipoEditar.Size = new System.Drawing.Size(100, 20);
            this.txTipoEditar.TabIndex = 14;
            // 
            // txtIdEditar
            // 
            this.txtIdEditar.Location = new System.Drawing.Point(91, 64);
            this.txtIdEditar.Name = "txtIdEditar";
            this.txtIdEditar.Size = new System.Drawing.Size(43, 20);
            this.txtIdEditar.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(594, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCadastroPizzas);
            this.Controls.Add(this.lblNomePizza);
            this.Controls.Add(this.dgvPizza1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Pizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza1)).EndInit();
            this.grpCadastroPizzas.ResumeLayout(false);
            this.grpCadastroPizzas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPizza1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPizza;
        private System.Windows.Forms.TextBox txtNomePizza;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.Label lblNomePizza;
        private System.Windows.Forms.GroupBox grpCadastroPizzas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button brnRemover;
        private System.Windows.Forms.Button btnSairCadastroPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdDeletar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txTipoEditar;
        private System.Windows.Forms.TextBox txtIdEditar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}