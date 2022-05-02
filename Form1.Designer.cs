namespace Class4_WFCEP
{
    partial class Form1
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
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o CEP:";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(321, 93);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(89, 23);
            this.BtnPesquisar.TabIndex = 1;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(40, 93);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 24);
            this.txtCEP.TabIndex = 2;
            this.txtCEP.Text = "148";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(40, 247);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(146, 24);
            this.txtBairro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bairro";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(40, 171);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(305, 24);
            this.txtLog.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logradouro";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(40, 327);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(305, 24);
            this.txtCidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(405, 327);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(51, 24);
            this.txtUF.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "UF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label5;
    }
}

