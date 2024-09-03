namespace _3NLIDTS_KARLANUÑEZ_04
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbtNombre = new System.Windows.Forms.TextBox();
            this.tbtApellido = new System.Windows.Forms.TextBox();
            this.tbtTelefono = new System.Windows.Forms.TextBox();
            this.tbtEstatura = new System.Windows.Forms.TextBox();
            this.tbtEdad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.bttguarda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbtNombre
            // 
            this.tbtNombre.Location = new System.Drawing.Point(129, 40);
            this.tbtNombre.Name = "tbtNombre";
            this.tbtNombre.Size = new System.Drawing.Size(128, 20);
            this.tbtNombre.TabIndex = 0;
            // 
            // tbtApellido
            // 
            this.tbtApellido.Location = new System.Drawing.Point(129, 71);
            this.tbtApellido.Name = "tbtApellido";
            this.tbtApellido.Size = new System.Drawing.Size(128, 20);
            this.tbtApellido.TabIndex = 1;
            // 
            // tbtTelefono
            // 
            this.tbtTelefono.Location = new System.Drawing.Point(129, 115);
            this.tbtTelefono.Name = "tbtTelefono";
            this.tbtTelefono.Size = new System.Drawing.Size(128, 20);
            this.tbtTelefono.TabIndex = 2;
            // 
            // tbtEstatura
            // 
            this.tbtEstatura.Location = new System.Drawing.Point(129, 158);
            this.tbtEstatura.Name = "tbtEstatura";
            this.tbtEstatura.Size = new System.Drawing.Size(128, 20);
            this.tbtEstatura.TabIndex = 3;
            // 
            // tbtEdad
            // 
            this.tbtEdad.Location = new System.Drawing.Point(129, 196);
            this.tbtEdad.Name = "tbtEdad";
            this.tbtEdad.Size = new System.Drawing.Size(128, 20);
            this.tbtEdad.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(55, 78);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFemenino);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.Location = new System.Drawing.Point(344, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(37, 62);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 1;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(39, 30);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // bttguarda
            // 
            this.bttguarda.Location = new System.Drawing.Point(383, 174);
            this.bttguarda.Name = "bttguarda";
            this.bttguarda.Size = new System.Drawing.Size(116, 62);
            this.bttguarda.TabIndex = 11;
            this.bttguarda.Text = "Guardar";
            this.bttguarda.UseVisualStyleBackColor = true;
            this.bttguarda.Click += new System.EventHandler(this.bttguarda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 62);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 347);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bttguarda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbtEdad);
            this.Controls.Add(this.tbtEstatura);
            this.Controls.Add(this.tbtTelefono);
            this.Controls.Add(this.tbtApellido);
            this.Controls.Add(this.tbtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbtNombre;
        private System.Windows.Forms.TextBox tbtApellido;
        private System.Windows.Forms.TextBox tbtTelefono;
        private System.Windows.Forms.TextBox tbtEstatura;
        private System.Windows.Forms.TextBox tbtEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Button bttguarda;
        private System.Windows.Forms.Button btnCancelar;
    }
}

