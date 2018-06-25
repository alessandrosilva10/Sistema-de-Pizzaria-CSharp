namespace Sistema_de_Pizzaria
{
    partial class RelatorioPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioPedido));
            this.crvPedido = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPedido
            // 
            this.crvPedido.ActiveViewIndex = -1;
            this.crvPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPedido.Location = new System.Drawing.Point(0, 0);
            this.crvPedido.Name = "crvPedido";
            this.crvPedido.Size = new System.Drawing.Size(800, 450);
            this.crvPedido.TabIndex = 0;
            this.crvPedido.Load += new System.EventHandler(this.crvPedido_Load);
            // 
            // RelatorioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioPedido";
            this.Text = "Relatorio de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioPedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPedido;
    }
}