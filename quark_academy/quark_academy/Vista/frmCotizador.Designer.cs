namespace quark_academy
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_chupin = new System.Windows.Forms.CheckBox();
            this.chb_cuello = new System.Windows.Forms.CheckBox();
            this.chb_manga_corta = new System.Windows.Forms.CheckBox();
            this.rab_pantalon = new System.Windows.Forms.RadioButton();
            this.rab_camisa = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rab_premium = new System.Windows.Forms.RadioButton();
            this.rab_standar = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_cantidad = new System.Windows.Forms.TextBox();
            this.tbx_precio = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_precio_final = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(404, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cotizador Express";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 33);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección de la Tienda";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.lbl_nombre.Location = new System.Drawing.Point(11, 10);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(93, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre Tienda";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_vendedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 33);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quark_academy.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(381, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Historial Cotizaciones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.ForeColor = System.Drawing.Color.Blue;
            this.lbl_vendedor.Location = new System.Drawing.Point(8, 9);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(231, 13);
            this.lbl_vendedor.TabIndex = 0;
            this.lbl_vendedor.Text = "Nombre y Apellido Vendedor | Código Vendedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chb_chupin);
            this.groupBox1.Controls.Add(this.chb_cuello);
            this.groupBox1.Controls.Add(this.chb_manga_corta);
            this.groupBox1.Controls.Add(this.rab_pantalon);
            this.groupBox1.Controls.Add(this.rab_camisa);
            this.groupBox1.Location = new System.Drawing.Point(15, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "_____________________________________________________";
            // 
            // chb_chupin
            // 
            this.chb_chupin.AutoSize = true;
            this.chb_chupin.Location = new System.Drawing.Point(128, 65);
            this.chb_chupin.Name = "chb_chupin";
            this.chb_chupin.Size = new System.Drawing.Size(61, 17);
            this.chb_chupin.TabIndex = 4;
            this.chb_chupin.Text = "Chupín";
            this.chb_chupin.UseVisualStyleBackColor = true;
            // 
            // chb_cuello
            // 
            this.chb_cuello.AutoSize = true;
            this.chb_cuello.Location = new System.Drawing.Point(239, 21);
            this.chb_cuello.Name = "chb_cuello";
            this.chb_cuello.Size = new System.Drawing.Size(78, 17);
            this.chb_cuello.TabIndex = 3;
            this.chb_cuello.Text = "Cuello mao";
            this.chb_cuello.UseVisualStyleBackColor = true;
            // 
            // chb_manga_corta
            // 
            this.chb_manga_corta.AutoSize = true;
            this.chb_manga_corta.Location = new System.Drawing.Point(128, 20);
            this.chb_manga_corta.Name = "chb_manga_corta";
            this.chb_manga_corta.Size = new System.Drawing.Size(87, 17);
            this.chb_manga_corta.TabIndex = 2;
            this.chb_manga_corta.Text = "Manga Corta";
            this.chb_manga_corta.UseVisualStyleBackColor = true;
            // 
            // rab_pantalon
            // 
            this.rab_pantalon.AutoSize = true;
            this.rab_pantalon.Location = new System.Drawing.Point(23, 65);
            this.rab_pantalon.Name = "rab_pantalon";
            this.rab_pantalon.Size = new System.Drawing.Size(67, 17);
            this.rab_pantalon.TabIndex = 1;
            this.rab_pantalon.TabStop = true;
            this.rab_pantalon.Text = "Pantalón";
            this.rab_pantalon.UseVisualStyleBackColor = true;
            // 
            // rab_camisa
            // 
            this.rab_camisa.AutoSize = true;
            this.rab_camisa.Checked = true;
            this.rab_camisa.Location = new System.Drawing.Point(23, 20);
            this.rab_camisa.Name = "rab_camisa";
            this.rab_camisa.Size = new System.Drawing.Size(59, 17);
            this.rab_camisa.TabIndex = 0;
            this.rab_camisa.TabStop = true;
            this.rab_camisa.Text = "Camisa";
            this.rab_camisa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unidad de stock disponibles:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_unidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 39);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(146, 15);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(43, 13);
            this.lbl_unidad.TabIndex = 7;
            this.lbl_unidad.Text = "______";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rab_premium);
            this.groupBox3.Controls.Add(this.rab_standar);
            this.groupBox3.Location = new System.Drawing.Point(15, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 45);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de Prenda";
            // 
            // rab_premium
            // 
            this.rab_premium.AutoSize = true;
            this.rab_premium.Location = new System.Drawing.Point(84, 19);
            this.rab_premium.Name = "rab_premium";
            this.rab_premium.Size = new System.Drawing.Size(65, 17);
            this.rab_premium.TabIndex = 7;
            this.rab_premium.TabStop = true;
            this.rab_premium.Text = "Premium";
            this.rab_premium.UseVisualStyleBackColor = true;
            // 
            // rab_standar
            // 
            this.rab_standar.AutoSize = true;
            this.rab_standar.Checked = true;
            this.rab_standar.Location = new System.Drawing.Point(6, 19);
            this.rab_standar.Name = "rab_standar";
            this.rab_standar.Size = new System.Drawing.Size(68, 17);
            this.rab_standar.TabIndex = 6;
            this.rab_standar.TabStop = true;
            this.rab_standar.Text = "Standard";
            this.rab_standar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbx_cantidad);
            this.groupBox4.Controls.Add(this.tbx_precio);
            this.groupBox4.Location = new System.Drawing.Point(201, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 45);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio unitario y Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "$";
            // 
            // tbx_cantidad
            // 
            this.tbx_cantidad.Location = new System.Drawing.Point(150, 16);
            this.tbx_cantidad.Name = "tbx_cantidad";
            this.tbx_cantidad.Size = new System.Drawing.Size(31, 20);
            this.tbx_cantidad.TabIndex = 1;
            // 
            // tbx_precio
            // 
            this.tbx_precio.Location = new System.Drawing.Point(21, 16);
            this.tbx_precio.Name = "tbx_precio";
            this.tbx_precio.Size = new System.Drawing.Size(62, 20);
            this.tbx_precio.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_precio_final);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btn_cotizar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 65);
            this.panel3.TabIndex = 9;
            // 
            // lbl_precio_final
            // 
            this.lbl_precio_final.AutoSize = true;
            this.lbl_precio_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_precio_final.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.lbl_precio_final.Location = new System.Drawing.Point(231, 20);
            this.lbl_precio_final.Name = "lbl_precio_final";
            this.lbl_precio_final.Size = new System.Drawing.Size(155, 26);
            this.lbl_precio_final.TabIndex = 3;
            this.lbl_precio_final.Text = "___________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.label8.Location = new System.Drawing.Point(206, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "$";
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.btn_cotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cotizar.ForeColor = System.Drawing.Color.White;
            this.btn_cotizar.Location = new System.Drawing.Point(13, 9);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(132, 47);
            this.btn_cotizar.TabIndex = 0;
            this.btn_cotizar.Text = "Cotizar";
            this.btn_cotizar.UseVisualStyleBackColor = false;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_chupin;
        private System.Windows.Forms.CheckBox chb_cuello;
        private System.Windows.Forms.CheckBox chb_manga_corta;
        private System.Windows.Forms.RadioButton rab_pantalon;
        private System.Windows.Forms.RadioButton rab_camisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rab_premium;
        private System.Windows.Forms.RadioButton rab_standar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_cantidad;
        private System.Windows.Forms.TextBox tbx_precio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_precio_final;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cotizar;
    }
}

