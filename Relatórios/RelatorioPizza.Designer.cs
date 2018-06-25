namespace Sistema_de_Pizzaria
{
    partial class RelatorioPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioPizza));
            this.crvPizza = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPizza
            // 
            this.crvPizza.ActiveViewIndex = -1;
            this.crvPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPizza.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPizza.Location = new System.Drawing.Point(0, 0);
            this.crvPizza.Name = "crvPizza";
            this.crvPizza.Size = new System.Drawing.Size(800, 450);
            this.crvPizza.TabIndex = 0;
            this.crvPizza.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // RelatorioPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvPizza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Pizzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPizza;
    }
}