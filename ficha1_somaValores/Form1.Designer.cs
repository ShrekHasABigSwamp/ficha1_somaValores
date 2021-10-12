
namespace ficha1_somaValores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_somar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.textBox_1valor = new System.Windows.Forms.TextBox();
            this.textBox_2valor = new System.Windows.Forms.TextBox();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.lbl_1valor = new System.Windows.Forms.Label();
            this.lbl_2valor = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_somar
            // 
            this.btn_somar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_somar.Location = new System.Drawing.Point(436, 110);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(76, 76);
            this.btn_somar.TabIndex = 0;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limpar.Location = new System.Drawing.Point(436, 192);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(76, 76);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_sair.Location = new System.Drawing.Point(436, 274);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(76, 76);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // textBox_1valor
            // 
            this.textBox_1valor.Location = new System.Drawing.Point(171, 140);
            this.textBox_1valor.Name = "textBox_1valor";
            this.textBox_1valor.Size = new System.Drawing.Size(206, 23);
            this.textBox_1valor.TabIndex = 3;
            // 
            // textBox_2valor
            // 
            this.textBox_2valor.Location = new System.Drawing.Point(171, 172);
            this.textBox_2valor.Name = "textBox_2valor";
            this.textBox_2valor.Size = new System.Drawing.Size(206, 23);
            this.textBox_2valor.TabIndex = 4;
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Location = new System.Drawing.Point(171, 304);
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.ReadOnly = true;
            this.textBox_resultado.Size = new System.Drawing.Size(206, 23);
            this.textBox_resultado.TabIndex = 5;
            // 
            // lbl_1valor
            // 
            this.lbl_1valor.AutoSize = true;
            this.lbl_1valor.Location = new System.Drawing.Point(67, 143);
            this.lbl_1valor.Name = "lbl_1valor";
            this.lbl_1valor.Size = new System.Drawing.Size(47, 15);
            this.lbl_1valor.TabIndex = 6;
            this.lbl_1valor.Text = "1º Valor";
            // 
            // lbl_2valor
            // 
            this.lbl_2valor.AutoSize = true;
            this.lbl_2valor.Location = new System.Drawing.Point(67, 175);
            this.lbl_2valor.Name = "lbl_2valor";
            this.lbl_2valor.Size = new System.Drawing.Size(47, 15);
            this.lbl_2valor.TabIndex = 7;
            this.lbl_2valor.Text = "2º Valor";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(67, 307);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(59, 15);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(130, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soma valores numéricos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_2valor);
            this.Controls.Add(this.lbl_1valor);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.textBox_2valor);
            this.Controls.Add(this.textBox_1valor);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_somar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox textBox_1valor;
        private System.Windows.Forms.TextBox textBox_2valor;
        private System.Windows.Forms.TextBox textBox_resultado;
        private System.Windows.Forms.Label lbl_1valor;
        private System.Windows.Forms.Label lbl_2valor;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label4;
    }
}

