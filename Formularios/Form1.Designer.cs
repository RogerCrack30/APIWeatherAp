
namespace Formularios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txtmostrar = new System.Windows.Forms.Button();
            this.lblpresion = new System.Windows.Forms.Label();
            this.lblvelocidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.velocidaddelViento = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.lblcondicion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltemperatura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhumedad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblamanecer = new System.Windows.Forms.Label();
            this.lblatardecer = new System.Windows.Forms.Label();
            this.lbldetaye = new System.Windows.Forms.Label();
            this.lblcondi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblcondi);
            this.groupBox1.Controls.Add(this.lbldetaye);
            this.groupBox1.Controls.Add(this.lblatardecer);
            this.groupBox1.Controls.Add(this.lblamanecer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblhumedad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbltemperatura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txtmostrar);
            this.groupBox1.Controls.Add(this.lblpresion);
            this.groupBox1.Controls.Add(this.lblvelocidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.velocidaddelViento);
            this.groupBox1.Controls.Add(this.txtcity);
            this.groupBox1.Controls.Add(this.lbldetalle);
            this.groupBox1.Controls.Add(this.lblcondicion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(83, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo";
            // 
            // Txtmostrar
            // 
            this.Txtmostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txtmostrar.Location = new System.Drawing.Point(272, 50);
            this.Txtmostrar.Name = "Txtmostrar";
            this.Txtmostrar.Size = new System.Drawing.Size(101, 42);
            this.Txtmostrar.TabIndex = 1;
            this.Txtmostrar.Text = "mostrar";
            this.Txtmostrar.UseVisualStyleBackColor = false;
            this.Txtmostrar.Click += new System.EventHandler(this.Txtmostrar_Click);
            // 
            // lblpresion
            // 
            this.lblpresion.AutoSize = true;
            this.lblpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpresion.Location = new System.Drawing.Point(384, 174);
            this.lblpresion.Name = "lblpresion";
            this.lblpresion.Size = new System.Drawing.Size(52, 29);
            this.lblpresion.TabIndex = 7;
            this.lblpresion.Text = "N|A";
            // 
            // lblvelocidad
            // 
            this.lblvelocidad.AutoSize = true;
            this.lblvelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvelocidad.Location = new System.Drawing.Point(420, 285);
            this.lblvelocidad.Name = "lblvelocidad";
            this.lblvelocidad.Size = new System.Drawing.Size(52, 29);
            this.lblvelocidad.TabIndex = 6;
            this.lblvelocidad.Text = "N|A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "precion";
            // 
            // velocidaddelViento
            // 
            this.velocidaddelViento.AutoSize = true;
            this.velocidaddelViento.Location = new System.Drawing.Point(268, 285);
            this.velocidaddelViento.Name = "velocidaddelViento";
            this.velocidaddelViento.Size = new System.Drawing.Size(146, 20);
            this.velocidaddelViento.TabIndex = 4;
            this.velocidaddelViento.Text = "velocidad del viento";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(97, 50);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 26);
            this.txtcity.TabIndex = 3;
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Location = new System.Drawing.Point(32, 266);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(56, 20);
            this.lbldetalle.TabIndex = 2;
            this.lbldetalle.Text = "detalle";
            // 
            // lblcondicion
            // 
            this.lblcondicion.AutoSize = true;
            this.lblcondicion.Location = new System.Drawing.Point(32, 302);
            this.lblcondicion.Name = "lblcondicion";
            this.lblcondicion.Size = new System.Drawing.Size(76, 20);
            this.lblcondicion.TabIndex = 1;
            this.lblcondicion.Text = "condicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Temperatura";
            // 
            // lbltemperatura
            // 
            this.lbltemperatura.AutoSize = true;
            this.lbltemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemperatura.Location = new System.Drawing.Point(400, 119);
            this.lbltemperatura.Name = "lbltemperatura";
            this.lbltemperatura.Size = new System.Drawing.Size(0, 46);
            this.lbltemperatura.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Humedad";
            // 
            // lblhumedad
            // 
            this.lblhumedad.AutoSize = true;
            this.lblhumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhumedad.Location = new System.Drawing.Point(400, 224);
            this.lblhumedad.Name = "lblhumedad";
            this.lblhumedad.Size = new System.Drawing.Size(0, 37);
            this.lblhumedad.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Amanecer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Atardecer";
            // 
            // lblamanecer
            // 
            this.lblamanecer.AutoSize = true;
            this.lblamanecer.Location = new System.Drawing.Point(117, 126);
            this.lblamanecer.Name = "lblamanecer";
            this.lblamanecer.Size = new System.Drawing.Size(0, 20);
            this.lblamanecer.TabIndex = 25;
            // 
            // lblatardecer
            // 
            this.lblatardecer.AutoSize = true;
            this.lblatardecer.Location = new System.Drawing.Point(117, 174);
            this.lblatardecer.Name = "lblatardecer";
            this.lblatardecer.Size = new System.Drawing.Size(0, 20);
            this.lblatardecer.TabIndex = 26;
            // 
            // lbldetaye
            // 
            this.lbldetaye.AutoSize = true;
            this.lbldetaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetaye.Location = new System.Drawing.Point(121, 266);
            this.lbldetaye.Name = "lbldetaye";
            this.lbldetaye.Size = new System.Drawing.Size(0, 29);
            this.lbldetaye.TabIndex = 27;
            // 
            // lblcondi
            // 
            this.lblcondi.AutoSize = true;
            this.lblcondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondi.Location = new System.Drawing.Point(126, 302);
            this.lblcondi.Name = "lblcondi";
            this.lblcondi.Size = new System.Drawing.Size(0, 29);
            this.lblcondi.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.the_sky_clouds_blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Txtmostrar;
        private System.Windows.Forms.Label lblpresion;
        private System.Windows.Forms.Label lblvelocidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label velocidaddelViento;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.Label lblcondicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltemperatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhumedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblatardecer;
        private System.Windows.Forms.Label lblamanecer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcondi;
        private System.Windows.Forms.Label lbldetaye;
    }
}

