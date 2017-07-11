namespace FiscalBr.App
{
    partial class frmMotorTributario
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
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonServico = new System.Windows.Forms.RadioButton();
            this.radioButtonProduto = new System.Windows.Forms.RadioButton();
            this.txtEx = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lnkBackTo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(126, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motor Tributário | IBPT";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(387, 26);
            this.txtToken.MaxLength = 64;
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(585, 20);
            this.txtToken.TabIndex = 3;
            this.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(923, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOKEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "CNPJ";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(22, 45);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Multiline = true;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(267, 40);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtEx);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 473);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(211, 256);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(153, 42);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "&Consultar (F5)";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonServico);
            this.groupBox3.Controls.Add(this.radioButtonProduto);
            this.groupBox3.Location = new System.Drawing.Point(22, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 108);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto / Serviço";
            // 
            // radioButtonServico
            // 
            this.radioButtonServico.AutoSize = true;
            this.radioButtonServico.Location = new System.Drawing.Point(220, 52);
            this.radioButtonServico.Name = "radioButtonServico";
            this.radioButtonServico.Size = new System.Drawing.Size(61, 17);
            this.radioButtonServico.TabIndex = 1;
            this.radioButtonServico.TabStop = true;
            this.radioButtonServico.Text = "Serviço";
            this.radioButtonServico.UseVisualStyleBackColor = true;
            // 
            // radioButtonProduto
            // 
            this.radioButtonProduto.AutoSize = true;
            this.radioButtonProduto.Location = new System.Drawing.Point(64, 52);
            this.radioButtonProduto.Name = "radioButtonProduto";
            this.radioButtonProduto.Size = new System.Drawing.Size(62, 17);
            this.radioButtonProduto.TabIndex = 0;
            this.radioButtonProduto.TabStop = true;
            this.radioButtonProduto.Text = "Produto";
            this.radioButtonProduto.UseVisualStyleBackColor = true;
            // 
            // txtEx
            // 
            this.txtEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEx.Location = new System.Drawing.Point(22, 256);
            this.txtEx.MaxLength = 20;
            this.txtEx.Multiline = true;
            this.txtEx.Name = "txtEx";
            this.txtEx.Size = new System.Drawing.Size(183, 42);
            this.txtEx.TabIndex = 3;
            this.txtEx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(22, 179);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(342, 42);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "EX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(295, 45);
            this.txtUf.MaxLength = 2;
            this.txtUf.Multiline = true;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(69, 40);
            this.txtUf.TabIndex = 3;
            this.txtUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "UF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 579);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(3, 16);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(594, 560);
            this.txtResult.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnkBackTo);
            this.panel1.Controls.Add(this.txtToken);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 52);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(384, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 579);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 579);
            this.panel3.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCnpj);
            this.groupBox5.Controls.Add(this.txtUf);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 106);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados Básicos";
            // 
            // lnkBackTo
            // 
            this.lnkBackTo.AutoSize = true;
            this.lnkBackTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBackTo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkBackTo.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkBackTo.Location = new System.Drawing.Point(12, 10);
            this.lnkBackTo.Name = "lnkBackTo";
            this.lnkBackTo.Size = new System.Drawing.Size(108, 31);
            this.lnkBackTo.TabIndex = 4;
            this.lnkBackTo.TabStop = true;
            this.lnkBackTo.Text = "< Voltar";
            this.lnkBackTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBackTo_LinkClicked);
            // 
            // frmMotorTributario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMotorTributario";
            this.ShowIcon = false;
            this.Text = "Motor Tributário IBPT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonServico;
        private System.Windows.Forms.RadioButton radioButtonProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel lnkBackTo;
    }
}