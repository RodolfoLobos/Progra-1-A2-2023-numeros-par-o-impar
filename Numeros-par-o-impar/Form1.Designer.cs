
namespace Numeros_par_o_impar
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
            this.btn_Par_o_Impar = new System.Windows.Forms.Button();
            this.txtpar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtPrimo = new System.Windows.Forms.TextBox();
            this.lblQue_es = new System.Windows.Forms.Label();
            this.btnDeterminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Par_o_Impar
            // 
            this.btn_Par_o_Impar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Par_o_Impar.Location = new System.Drawing.Point(82, 159);
            this.btn_Par_o_Impar.Name = "btn_Par_o_Impar";
            this.btn_Par_o_Impar.Size = new System.Drawing.Size(154, 33);
            this.btn_Par_o_Impar.TabIndex = 0;
            this.btn_Par_o_Impar.Text = "Par o Impar";
            this.btn_Par_o_Impar.UseVisualStyleBackColor = true;
            this.btn_Par_o_Impar.Click += new System.EventHandler(this.btn_Par_o_Impar_Click);
            // 
            // txtpar
            // 
            this.txtpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpar.Location = new System.Drawing.Point(97, 90);
            this.txtpar.Name = "txtpar";
            this.txtpar.Size = new System.Drawing.Size(129, 35);
            this.txtpar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "INTRODUCE UN NÚMERO";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(109, 216);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 27);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Qué es?";
            // 
            // txtPrimo
            // 
            this.txtPrimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimo.Location = new System.Drawing.Point(649, 90);
            this.txtPrimo.Name = "txtPrimo";
            this.txtPrimo.Size = new System.Drawing.Size(129, 35);
            this.txtPrimo.TabIndex = 4;
            // 
            // lblQue_es
            // 
            this.lblQue_es.AutoSize = true;
            this.lblQue_es.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQue_es.Location = new System.Drawing.Point(658, 216);
            this.lblQue_es.Name = "lblQue_es";
            this.lblQue_es.Size = new System.Drawing.Size(103, 27);
            this.lblQue_es.TabIndex = 5;
            this.lblQue_es.Text = "Qué es?";
            // 
            // btnDeterminar
            // 
            this.btnDeterminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminar.Location = new System.Drawing.Point(635, 149);
            this.btnDeterminar.Name = "btnDeterminar";
            this.btnDeterminar.Size = new System.Drawing.Size(143, 34);
            this.btnDeterminar.TabIndex = 6;
            this.btnDeterminar.Text = "Determinar";
            this.btnDeterminar.UseVisualStyleBackColor = true;
            this.btnDeterminar.Click += new System.EventHandler(this.btnDeterminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "INTRODUCE UN NÚMERO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeterminar);
            this.Controls.Add(this.lblQue_es);
            this.Controls.Add(this.txtPrimo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpar);
            this.Controls.Add(this.btn_Par_o_Impar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Par_o_Impar;
        private System.Windows.Forms.TextBox txtpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtPrimo;
        private System.Windows.Forms.Label lblQue_es;
        private System.Windows.Forms.Button btnDeterminar;
        private System.Windows.Forms.Label label3;
    }
}

