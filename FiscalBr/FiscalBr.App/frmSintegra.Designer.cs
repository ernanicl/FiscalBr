namespace FiscalBr.App
{
    partial class frmSintegra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSintegra));
            this.sfMapBrazil = new EGIS.Controls.SFMap();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkBackTo = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfMapBrazil
            // 
            this.sfMapBrazil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfMapBrazil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMapBrazil.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMapBrazil.CentrePoint2D")));
            this.sfMapBrazil.Location = new System.Drawing.Point(209, 58);
            this.sfMapBrazil.MapBackColor = System.Drawing.Color.Transparent;
            this.sfMapBrazil.Name = "sfMapBrazil";
            this.sfMapBrazil.PanSelectMode = EGIS.Controls.PanSelectMode.Pan;
            this.sfMapBrazil.RenderQuality = EGIS.ShapeFileLib.RenderQuality.Auto;
            this.sfMapBrazil.Size = new System.Drawing.Size(616, 451);
            this.sfMapBrazil.TabIndex = 0;
            this.sfMapBrazil.UseMercatorProjection = false;
            this.sfMapBrazil.ZoomLevel = 1D;
            this.sfMapBrazil.ZoomToSelectedExtentWhenCtrlKeydown = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lnkBackTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SintegraBr";
            // 
            // lnkBackTo
            // 
            this.lnkBackTo.AutoSize = true;
            this.lnkBackTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBackTo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkBackTo.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkBackTo.Location = new System.Drawing.Point(12, 9);
            this.lnkBackTo.Name = "lnkBackTo";
            this.lnkBackTo.Size = new System.Drawing.Size(108, 31);
            this.lnkBackTo.TabIndex = 0;
            this.lnkBackTo.TabStop = true;
            this.lnkBackTo.Text = "< Voltar";
            this.lnkBackTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBackTo_LinkClicked);
            // 
            // frmSintegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 521);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sfMapBrazil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSintegra";
            this.Text = "SintegraBr | Exemplos";
            this.Load += new System.EventHandler(this.frmSintegra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EGIS.Controls.SFMap sfMapBrazil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkBackTo;
        private System.Windows.Forms.Label label1;
    }
}