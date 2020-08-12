namespace hilos_pro
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.ProgressBar();
            this.p2 = new System.Windows.Forms.ProgressBar();
            this.p3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Iniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(92, 12);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(400, 5);
            this.p1.TabIndex = 2;
            // 
            // p2
            // 
            this.p2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.p2.Location = new System.Drawing.Point(92, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(400, 5);
            this.p2.TabIndex = 3;
            // 
            // p3
            // 
            this.p3.ForeColor = System.Drawing.Color.Red;
            this.p3.Location = new System.Drawing.Point(92, 28);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(400, 5);
            this.p3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar p1;
        private System.Windows.Forms.ProgressBar p2;
        private System.Windows.Forms.ProgressBar p3;
    }
}

