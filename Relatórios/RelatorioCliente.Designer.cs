namespace Sistema_de_Pizzaria
{
    partial class frmRelatorioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioCliente));
            this.crvCliente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCliente
            // 
            this.crvCliente.ActiveViewIndex = -1;
            this.crvCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCliente.Location = new System.Drawing.Point(0, 0);
            this.crvCliente.Name = "crvCliente";
            this.crvCliente.Size = new System.Drawing.Size(800, 450);
            this.crvCliente.TabIndex = 0;
            this.crvCliente.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioCliente";
            this.Text = "Relatório de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCliente;
    }
}