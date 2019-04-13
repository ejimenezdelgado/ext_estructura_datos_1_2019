namespace Vector
{
    partial class frmPrincipal
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
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtIniciador = new System.Windows.Forms.NumericUpDown();
            this.pnlCalculo = new System.Windows.Forms.Panel();
            this.splPanels = new System.Windows.Forms.SplitContainer();
            this.txtImpresionNumero = new System.Windows.Forms.ListBox();
            this.lblCalculos = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.grbPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciador)).BeginInit();
            this.pnlCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPanels)).BeginInit();
            this.splPanels.Panel1.SuspendLayout();
            this.splPanels.Panel2.SuspendLayout();
            this.splPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.txtIniciador);
            this.grbPrincipal.Controls.Add(this.btnIniciar);
            this.grbPrincipal.Controls.Add(this.btnAgregar);
            this.grbPrincipal.Controls.Add(this.txtNumero);
            this.grbPrincipal.Controls.Add(this.lblNumero);
            this.grbPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(673, 100);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            this.grbPrincipal.Text = "Ingresar numero:";
            this.grbPrincipal.Enter += new System.EventHandler(this.grbPrincipal_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(256, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(130, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(120, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(62, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(423, 28);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 35);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtIniciador
            // 
            this.txtIniciador.Location = new System.Drawing.Point(504, 35);
            this.txtIniciador.Name = "txtIniciador";
            this.txtIniciador.Size = new System.Drawing.Size(120, 22);
            this.txtIniciador.TabIndex = 4;
            // 
            // pnlCalculo
            // 
            this.pnlCalculo.Controls.Add(this.splPanels);
            this.pnlCalculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalculo.Location = new System.Drawing.Point(0, 100);
            this.pnlCalculo.Name = "pnlCalculo";
            this.pnlCalculo.Size = new System.Drawing.Size(673, 373);
            this.pnlCalculo.TabIndex = 1;
            // 
            // splPanels
            // 
            this.splPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPanels.Location = new System.Drawing.Point(0, 0);
            this.splPanels.Name = "splPanels";
            // 
            // splPanels.Panel1
            // 
            this.splPanels.Panel1.Controls.Add(this.txtImpresionNumero);
            // 
            // splPanels.Panel2
            // 
            this.splPanels.Panel2.Controls.Add(this.txtMinimo);
            this.splPanels.Panel2.Controls.Add(this.txtMaximo);
            this.splPanels.Panel2.Controls.Add(this.txtSuma);
            this.splPanels.Panel2.Controls.Add(this.txtPromedio);
            this.splPanels.Panel2.Controls.Add(this.lblMinimo);
            this.splPanels.Panel2.Controls.Add(this.lblMaximo);
            this.splPanels.Panel2.Controls.Add(this.lblPromedio);
            this.splPanels.Panel2.Controls.Add(this.lblSuma);
            this.splPanels.Panel2.Controls.Add(this.lblCalculos);
            this.splPanels.Size = new System.Drawing.Size(673, 373);
            this.splPanels.SplitterDistance = 224;
            this.splPanels.TabIndex = 0;
            // 
            // txtImpresionNumero
            // 
            this.txtImpresionNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImpresionNumero.FormattingEnabled = true;
            this.txtImpresionNumero.ItemHeight = 16;
            this.txtImpresionNumero.Location = new System.Drawing.Point(0, 0);
            this.txtImpresionNumero.Name = "txtImpresionNumero";
            this.txtImpresionNumero.Size = new System.Drawing.Size(224, 373);
            this.txtImpresionNumero.TabIndex = 0;
            // 
            // lblCalculos
            // 
            this.lblCalculos.AutoSize = true;
            this.lblCalculos.Location = new System.Drawing.Point(25, 18);
            this.lblCalculos.Name = "lblCalculos";
            this.lblCalculos.Size = new System.Drawing.Size(65, 17);
            this.lblCalculos.TabIndex = 2;
            this.lblCalculos.Text = "Calculos:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(25, 63);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(48, 17);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "Suma:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(25, 91);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(72, 17);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(25, 119);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(59, 17);
            this.lblMaximo.TabIndex = 5;
            this.lblMaximo.Text = "Máximo:";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(25, 156);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(56, 17);
            this.lblMinimo.TabIndex = 6;
            this.lblMinimo.Text = "Mínimo:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(103, 86);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(142, 22);
            this.txtPromedio.TabIndex = 7;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(103, 58);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(142, 22);
            this.txtSuma.TabIndex = 8;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(103, 114);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.ReadOnly = true;
            this.txtMaximo.Size = new System.Drawing.Size(142, 22);
            this.txtMaximo.TabIndex = 9;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(103, 142);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.ReadOnly = true;
            this.txtMinimo.Size = new System.Drawing.Size(142, 22);
            this.txtMinimo.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(673, 473);
            this.Controls.Add(this.pnlCalculo);
            this.Controls.Add(this.grbPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciador)).EndInit();
            this.pnlCalculo.ResumeLayout(false);
            this.splPanels.Panel1.ResumeLayout(false);
            this.splPanels.Panel2.ResumeLayout(false);
            this.splPanels.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPanels)).EndInit();
            this.splPanels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.NumericUpDown txtIniciador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel pnlCalculo;
        private System.Windows.Forms.SplitContainer splPanels;
        private System.Windows.Forms.ListBox txtImpresionNumero;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblCalculos;
    }
}

