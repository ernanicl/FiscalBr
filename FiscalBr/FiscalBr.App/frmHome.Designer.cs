namespace FiscalBr.App
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSintegraBr = new System.Windows.Forms.Button();
            this.btnMotorTributarioIbpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ferramentas";
            // 
            // btnSintegraBr
            // 
            this.btnSintegraBr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSintegraBr.FlatAppearance.BorderSize = 0;
            this.btnSintegraBr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintegraBr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSintegraBr.ForeColor = System.Drawing.Color.White;
            this.btnSintegraBr.Image = global::FiscalBr.App.Properties.Resources.Defrag_64px;
            this.btnSintegraBr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSintegraBr.Location = new System.Drawing.Point(173, 87);
            this.btnSintegraBr.Name = "btnSintegraBr";
            this.btnSintegraBr.Size = new System.Drawing.Size(105, 105);
            this.btnSintegraBr.TabIndex = 0;
            this.btnSintegraBr.Text = "SintegraBr";
            this.btnSintegraBr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSintegraBr.UseVisualStyleBackColor = false;
            this.btnSintegraBr.Click += new System.EventHandler(this.btnSintegraBr_Click);
            // 
            // btnMotorTributarioIbpt
            // 
            this.btnMotorTributarioIbpt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMotorTributarioIbpt.FlatAppearance.BorderSize = 0;
            this.btnMotorTributarioIbpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotorTributarioIbpt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorTributarioIbpt.ForeColor = System.Drawing.Color.White;
            this.btnMotorTributarioIbpt.Image = global::FiscalBr.App.Properties.Resources.Gears_64px;
            this.btnMotorTributarioIbpt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMotorTributarioIbpt.Location = new System.Drawing.Point(33, 87);
            this.btnMotorTributarioIbpt.Name = "btnMotorTributarioIbpt";
            this.btnMotorTributarioIbpt.Size = new System.Drawing.Size(105, 105);
            this.btnMotorTributarioIbpt.TabIndex = 0;
            this.btnMotorTributarioIbpt.Text = "Motor Tributário IBPT";
            this.btnMotorTributarioIbpt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMotorTributarioIbpt.UseVisualStyleBackColor = false;
            this.btnMotorTributarioIbpt.Click += new System.EventHandler(this.btnMotorTributarioIbpt_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSintegraBr);
            this.Controls.Add(this.btnMotorTributarioIbpt);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMotorTributarioIbpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSintegraBr;
    }
}