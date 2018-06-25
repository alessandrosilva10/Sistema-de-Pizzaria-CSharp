namespace Sistema_de_Pizzaria
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdPizza = new System.Windows.Forms.TextBox();
            this.txtIdBebida = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDataEditar = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObsEditar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdPedidoEditar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdClienteEditar = new System.Windows.Forms.TextBox();
            this.txtIdPizzaEditar = new System.Windows.Forms.TextBox();
            this.txtIdBebidaEditar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdValorEditar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantidadeEditar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdDeletar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(33, 55);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(851, 231);
            this.dgvPedido.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Blue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(97, 319);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(153, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sair";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.ForeColor = System.Drawing.Color.Blue;
            this.txtIdPedido.Location = new System.Drawing.Point(87, 68);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(91, 20);
            this.txtIdPedido.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.ForeColor = System.Drawing.Color.Blue;
            this.txtIdCliente.Location = new System.Drawing.Point(87, 97);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(91, 20);
            this.txtIdCliente.TabIndex = 6;
            // 
            // txtIdPizza
            // 
            this.txtIdPizza.ForeColor = System.Drawing.Color.Blue;
            this.txtIdPizza.Location = new System.Drawing.Point(87, 122);
            this.txtIdPizza.Name = "txtIdPizza";
            this.txtIdPizza.Size = new System.Drawing.Size(157, 20);
            this.txtIdPizza.TabIndex = 7;
            // 
            // txtIdBebida
            // 
            this.txtIdBebida.ForeColor = System.Drawing.Color.Blue;
            this.txtIdBebida.Location = new System.Drawing.Point(87, 148);
            this.txtIdBebida.Name = "txtIdBebida";
            this.txtIdBebida.Size = new System.Drawing.Size(157, 20);
            this.txtIdBebida.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.ForeColor = System.Drawing.Color.Blue;
            this.txtValor.Location = new System.Drawing.Point(87, 177);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(157, 20);
            this.txtValor.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.ForeColor = System.Drawing.Color.Blue;
            this.txtQuantidade.Location = new System.Drawing.Point(87, 203);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(157, 20);
            this.txtQuantidade.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Pizza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID Bebida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(27, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(29, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "OBS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(27, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data";
            // 
            // txtObs
            // 
            this.txtObs.ForeColor = System.Drawing.Color.Blue;
            this.txtObs.Location = new System.Drawing.Point(87, 256);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(157, 20);
            this.txtObs.TabIndex = 23;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Blue;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(42, 323);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(79, 35);
            this.btnGravar.TabIndex = 25;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.mtbData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdPedido);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.txtIdPizza);
            this.groupBox1.Controls.Add(this.txtIdBebida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 376);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(38, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(201, 24);
            this.label20.TabIndex = 27;
            this.label20.Text = "Cadastro no Sistema";
            // 
            // mtbData
            // 
            this.mtbData.ForeColor = System.Drawing.Color.Blue;
            this.mtbData.Location = new System.Drawing.Point(87, 230);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(66, 20);
            this.mtbData.TabIndex = 26;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(213, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(470, 33);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cadastro de Pedidos no Sistema";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtDataEditar);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtObsEditar);
            this.groupBox4.Controls.Add(this.btnEditar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtIdPedidoEditar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtIdClienteEditar);
            this.groupBox4.Controls.Add(this.txtIdPizzaEditar);
            this.groupBox4.Controls.Add(this.txtIdBebidaEditar);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtIdValorEditar);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtQuantidadeEditar);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(612, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 376);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(60, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(173, 24);
            this.label21.TabIndex = 28;
            this.label21.Text = "Editar no Sistema";
            // 
            // txtDataEditar
            // 
            this.txtDataEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtDataEditar.Location = new System.Drawing.Point(87, 230);
            this.txtDataEditar.Mask = "00/00/0000";
            this.txtDataEditar.Name = "txtDataEditar";
            this.txtDataEditar.Size = new System.Drawing.Size(66, 20);
            this.txtDataEditar.TabIndex = 26;
            this.txtDataEditar.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(27, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "ID Pedido";
            // 
            // txtObsEditar
            // 
            this.txtObsEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtObsEditar.Location = new System.Drawing.Point(87, 256);
            this.txtObsEditar.Name = "txtObsEditar";
            this.txtObsEditar.Size = new System.Drawing.Size(157, 20);
            this.txtObsEditar.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(29, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "OBS";
            // 
            // txtIdPedidoEditar
            // 
            this.txtIdPedidoEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtIdPedidoEditar.Location = new System.Drawing.Point(87, 68);
            this.txtIdPedidoEditar.Name = "txtIdPedidoEditar";
            this.txtIdPedidoEditar.Size = new System.Drawing.Size(102, 20);
            this.txtIdPedidoEditar.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(27, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Data";
            // 
            // txtIdClienteEditar
            // 
            this.txtIdClienteEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtIdClienteEditar.Location = new System.Drawing.Point(87, 97);
            this.txtIdClienteEditar.Name = "txtIdClienteEditar";
            this.txtIdClienteEditar.Size = new System.Drawing.Size(102, 20);
            this.txtIdClienteEditar.TabIndex = 6;
            // 
            // txtIdPizzaEditar
            // 
            this.txtIdPizzaEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtIdPizzaEditar.Location = new System.Drawing.Point(87, 122);
            this.txtIdPizzaEditar.Name = "txtIdPizzaEditar";
            this.txtIdPizzaEditar.Size = new System.Drawing.Size(102, 20);
            this.txtIdPizzaEditar.TabIndex = 7;
            // 
            // txtIdBebidaEditar
            // 
            this.txtIdBebidaEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtIdBebidaEditar.Location = new System.Drawing.Point(87, 148);
            this.txtIdBebidaEditar.Name = "txtIdBebidaEditar";
            this.txtIdBebidaEditar.Size = new System.Drawing.Size(102, 20);
            this.txtIdBebidaEditar.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(27, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Quantidade";
            // 
            // txtIdValorEditar
            // 
            this.txtIdValorEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtIdValorEditar.Location = new System.Drawing.Point(87, 177);
            this.txtIdValorEditar.Name = "txtIdValorEditar";
            this.txtIdValorEditar.Size = new System.Drawing.Size(157, 20);
            this.txtIdValorEditar.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(27, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Valor";
            // 
            // txtQuantidadeEditar
            // 
            this.txtQuantidadeEditar.ForeColor = System.Drawing.Color.Blue;
            this.txtQuantidadeEditar.Location = new System.Drawing.Point(87, 203);
            this.txtQuantidadeEditar.Name = "txtQuantidadeEditar";
            this.txtQuantidadeEditar.Size = new System.Drawing.Size(157, 20);
            this.txtQuantidadeEditar.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(27, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "ID Bebida";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(27, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "ID Cliente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(27, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "ID Pizza";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtIdDeletar);
            this.groupBox2.Location = new System.Drawing.Point(350, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 170);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(17, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Excluir do Sistema";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(27, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "ID Pedido";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(63, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remover";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdDeletar
            // 
            this.txtIdDeletar.ForeColor = System.Drawing.Color.Blue;
            this.txtIdDeletar.Location = new System.Drawing.Point(87, 68);
            this.txtIdDeletar.Name = "txtIdDeletar";
            this.txtIdDeletar.Size = new System.Drawing.Size(53, 20);
            this.txtIdDeletar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 109);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(921, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdPizza;
        private System.Windows.Forms.TextBox txtIdBebida;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox txtDataEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObsEditar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdPedidoEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdClienteEditar;
        private System.Windows.Forms.TextBox txtIdPizzaEditar;
        private System.Windows.Forms.TextBox txtIdBebidaEditar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdValorEditar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQuantidadeEditar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdDeletar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}