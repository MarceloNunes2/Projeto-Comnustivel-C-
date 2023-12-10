namespace Combustivel
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtQuantidadeLitros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(240, 151);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(177, 81);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(298, 261);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(371, 134);
            this.lstResultados.TabIndex = 2;
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.Location = new System.Drawing.Point(329, 12);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(318, 21);
            this.cmbCombustivel.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(566, 151);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(181, 81);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtQuantidadeLitros
            // 
            this.txtQuantidadeLitros.Location = new System.Drawing.Point(377, 103);
            this.txtQuantidadeLitros.Name = "txtQuantidadeLitros";
            this.txtQuantidadeLitros.Size = new System.Drawing.Size(200, 20);
            this.txtQuantidadeLitros.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(381, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade De Litros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(941, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidadeLitros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cmbCombustivel);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtQuantidadeLitros;
        private System.Windows.Forms.Label label1;
    }
}

