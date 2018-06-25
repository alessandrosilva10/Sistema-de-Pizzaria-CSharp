namespace Sistema_de_Pizzaria
{
    partial class RelatorioBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioBebida));
            this.crvBebida = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBebida
            // 
            this.crvBebida.ActiveViewIndex = -1;
            this.crvBebida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBebida.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBebida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBebida.Location = new System.Drawing.Point(0, 0);
            this.crvBebida.Name = "crvBebida";
            this.crvBebida.Size = new System.Drawing.Size(800, 450);
            this.crvBebida.TabIndex = 0;
            this.crvBebida.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // RelatorioBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvBebida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioBebida";
            this.Text = "Relatorio de Bebidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBebida;
    }
}