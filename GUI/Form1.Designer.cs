namespace GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cajaNumeroDeLiquidacion = new System.Windows.Forms.TextBox();
            this.cajaIdentificacion = new System.Windows.Forms.TextBox();
            this.comboTipoDeAfiliacion = new System.Windows.Forms.ComboBox();
            this.cajaSalario = new System.Windows.Forms.TextBox();
            this.cajaValorDelServicio = new System.Windows.Forms.TextBox();
            this.botonCalcularLiquidacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de liquidacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de afiliacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario devengado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor del servicio prestado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cajaNumeroDeLiquidacion
            // 
            this.cajaNumeroDeLiquidacion.Location = new System.Drawing.Point(202, 44);
            this.cajaNumeroDeLiquidacion.Name = "cajaNumeroDeLiquidacion";
            this.cajaNumeroDeLiquidacion.Size = new System.Drawing.Size(100, 20);
            this.cajaNumeroDeLiquidacion.TabIndex = 5;
            this.cajaNumeroDeLiquidacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cajaIdentificacion
            // 
            this.cajaIdentificacion.Location = new System.Drawing.Point(202, 82);
            this.cajaIdentificacion.Name = "cajaIdentificacion";
            this.cajaIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.cajaIdentificacion.TabIndex = 6;
            this.cajaIdentificacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboTipoDeAfiliacion
            // 
            this.comboTipoDeAfiliacion.FormattingEnabled = true;
            this.comboTipoDeAfiliacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subcidiado"});
            this.comboTipoDeAfiliacion.Location = new System.Drawing.Point(202, 128);
            this.comboTipoDeAfiliacion.Name = "comboTipoDeAfiliacion";
            this.comboTipoDeAfiliacion.Size = new System.Drawing.Size(121, 21);
            this.comboTipoDeAfiliacion.TabIndex = 7;
            this.comboTipoDeAfiliacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cajaSalario
            // 
            this.cajaSalario.Location = new System.Drawing.Point(202, 166);
            this.cajaSalario.Name = "cajaSalario";
            this.cajaSalario.Size = new System.Drawing.Size(100, 20);
            this.cajaSalario.TabIndex = 8;
            // 
            // cajaValorDelServicio
            // 
            this.cajaValorDelServicio.Location = new System.Drawing.Point(202, 203);
            this.cajaValorDelServicio.Name = "cajaValorDelServicio";
            this.cajaValorDelServicio.Size = new System.Drawing.Size(100, 20);
            this.cajaValorDelServicio.TabIndex = 9;
            // 
            // botonCalcularLiquidacion
            // 
            this.botonCalcularLiquidacion.Location = new System.Drawing.Point(202, 307);
            this.botonCalcularLiquidacion.Name = "botonCalcularLiquidacion";
            this.botonCalcularLiquidacion.Size = new System.Drawing.Size(135, 23);
            this.botonCalcularLiquidacion.TabIndex = 10;
            this.botonCalcularLiquidacion.Text = "Calcular Liquidacion";
            this.botonCalcularLiquidacion.UseVisualStyleBackColor = true;
            this.botonCalcularLiquidacion.Click += new System.EventHandler(this.botonCalcularLiquidacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 377);
            this.Controls.Add(this.botonCalcularLiquidacion);
            this.Controls.Add(this.cajaValorDelServicio);
            this.Controls.Add(this.cajaSalario);
            this.Controls.Add(this.comboTipoDeAfiliacion);
            this.Controls.Add(this.cajaIdentificacion);
            this.Controls.Add(this.cajaNumeroDeLiquidacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cajaNumeroDeLiquidacion;
        private System.Windows.Forms.TextBox cajaIdentificacion;
        private System.Windows.Forms.ComboBox comboTipoDeAfiliacion;
        private System.Windows.Forms.TextBox cajaSalario;
        private System.Windows.Forms.TextBox cajaValorDelServicio;
        private System.Windows.Forms.Button botonCalcularLiquidacion;
    }
}

