namespace Ejercicios
{
    partial class VentanaEjercicios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.Boton1 = new System.Windows.Forms.Button();
            this.Boton2 = new System.Windows.Forms.Button();
            this.Boton3 = new System.Windows.Forms.Button();
            this.Boton4 = new System.Windows.Forms.Button();
            this.Boton5 = new System.Windows.Forms.Button();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(29, 18);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(339, 29);
            this.LabelTitulo.TabIndex = 2;
            this.LabelTitulo.Text = "EJERCICIOS PROGRAMACIÓN 2";
            // 
            // Boton1
            // 
            this.Boton1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Boton1.Location = new System.Drawing.Point(27, 106);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(163, 65);
            this.Boton1.TabIndex = 3;
            this.Boton1.Text = "Secuencial";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Boton2
            // 
            this.Boton2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Boton2.Location = new System.Drawing.Point(196, 106);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(165, 65);
            this.Boton2.TabIndex = 4;
            this.Boton2.Text = "Ejemplo If";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // Boton3
            // 
            this.Boton3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Boton3.Location = new System.Drawing.Point(27, 195);
            this.Boton3.Name = "Boton3";
            this.Boton3.Size = new System.Drawing.Size(163, 65);
            this.Boton3.TabIndex = 5;
            this.Boton3.Text = "Ejemplo If Else";
            this.Boton3.UseVisualStyleBackColor = true;
            this.Boton3.Click += new System.EventHandler(this.Boton3_Click);
            // 
            // Boton4
            // 
            this.Boton4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Boton4.Location = new System.Drawing.Point(196, 195);
            this.Boton4.Name = "Boton4";
            this.Boton4.Size = new System.Drawing.Size(165, 65);
            this.Boton4.TabIndex = 7;
            this.Boton4.Text = "Ejemplo If Anidado";
            this.Boton4.UseVisualStyleBackColor = true;
            this.Boton4.Click += new System.EventHandler(this.Boton4_Click);
            // 
            // Boton5
            // 
            this.Boton5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Boton5.Location = new System.Drawing.Point(111, 281);
            this.Boton5.Name = "Boton5";
            this.Boton5.Size = new System.Drawing.Size(163, 65);
            this.Boton5.TabIndex = 10;
            this.Boton5.Text = "Ejemplo Switch";
            this.Boton5.UseVisualStyleBackColor = true;
            this.Boton5.Click += new System.EventHandler(this.Boton5_Click);
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(29, 56);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(194, 29);
            this.LabelNombre.TabIndex = 11;
            this.LabelNombre.Text = "Christian Martínez";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button1.Location = new System.Drawing.Point(269, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "Trailer Catify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VentanaEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.Boton5);
            this.Controls.Add(this.Boton4);
            this.Controls.Add(this.Boton3);
            this.Controls.Add(this.Boton2);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.LabelTitulo);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "VentanaEjercicios";
            this.Text = "Ejercicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Button Boton1;
        private System.Windows.Forms.Button Boton2;
        private System.Windows.Forms.Button Boton3;
        private System.Windows.Forms.Button Boton4;
        private System.Windows.Forms.Button Boton5;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Button button1;
    }
}

