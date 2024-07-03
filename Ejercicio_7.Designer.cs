namespace Ejercicios_Segunda_Unidad_L3
{
    partial class Ejercicio_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_7));
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLlamadas = new System.Windows.Forms.ListView();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmInternacional = new System.Windows.Forms.RadioButton();
            this.rbmNacional = new System.Windows.Forms.RadioButton();
            this.lbFecha = new System.Windows.Forms.Label();
            this.rbInternacional = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripLabel();
            this.tsCancelar = new System.Windows.Forms.ToolStripLabel();
            this.tsRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsSalir = new System.Windows.Forms.ToolStripLabel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(674, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 16);
            this.lblFecha.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 48;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(667, 122);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(0, 16);
            this.lbHora.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cantidad de Minutos\r\n";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(188, 92);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 22);
            this.txtMinutos.TabIndex = 45;
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutos_KeyPress);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(548, 56);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(0, 16);
            this.lbPrecio.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Numero de Telefono\r\n";
            // 
            // lvLlamadas
            // 
            this.lvLlamadas.HideSelection = false;
            this.lvLlamadas.Location = new System.Drawing.Point(12, 311);
            this.lvLlamadas.Name = "lvLlamadas";
            this.lvLlamadas.Size = new System.Drawing.Size(796, 237);
            this.lvLlamadas.TabIndex = 39;
            this.lvLlamadas.UseCompatibleStateImageBehavior = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(19, 92);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 35;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "CONTROL DE REGISTRO DE LLAMADAS\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbmInternacional);
            this.groupBox1.Controls.Add(this.rbmNacional);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.rbInternacional);
            this.groupBox1.Controls.Add(this.rbNacional);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 89);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Llamada";
            // 
            // rbmInternacional
            // 
            this.rbmInternacional.AutoSize = true;
            this.rbmInternacional.Location = new System.Drawing.Point(601, 35);
            this.rbmInternacional.Name = "rbmInternacional";
            this.rbmInternacional.Size = new System.Drawing.Size(139, 20);
            this.rbmInternacional.TabIndex = 53;
            this.rbmInternacional.TabStop = true;
            this.rbmInternacional.Text = "Movil Internacional";
            this.rbmInternacional.UseVisualStyleBackColor = true;
            // 
            // rbmNacional
            // 
            this.rbmNacional.AutoSize = true;
            this.rbmNacional.Location = new System.Drawing.Point(424, 35);
            this.rbmNacional.Name = "rbmNacional";
            this.rbmNacional.Size = new System.Drawing.Size(117, 20);
            this.rbmNacional.TabIndex = 52;
            this.rbmNacional.TabStop = true;
            this.rbmNacional.Text = "Movil Nacional";
            this.rbmNacional.UseVisualStyleBackColor = true;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(648, 38);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 16);
            this.lbFecha.TabIndex = 43;
            // 
            // rbInternacional
            // 
            this.rbInternacional.AutoSize = true;
            this.rbInternacional.Location = new System.Drawing.Point(230, 35);
            this.rbInternacional.Name = "rbInternacional";
            this.rbInternacional.Size = new System.Drawing.Size(129, 20);
            this.rbInternacional.TabIndex = 51;
            this.rbInternacional.TabStop = true;
            this.rbInternacional.Text = "Fijo Internacional";
            this.rbInternacional.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Location = new System.Drawing.Point(44, 35);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(107, 20);
            this.rbNacional.TabIndex = 50;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Fijo Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsRegistrar,
            this.toolStripButton3,
            this.tsCancelar,
            this.toolStripButton2,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 29);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "Registrar llamda";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.toolStrip2.Location = new System.Drawing.Point(0, 29);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 56;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 25);
            this.toolStripButton1.Text = "Registro de llamdas";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(21, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // tsCancelar
            // 
            this.tsCancelar.Name = "tsCancelar";
            this.tsCancelar.Size = new System.Drawing.Size(164, 25);
            this.tsCancelar.Text = "CANCELAR REGISTRO";
            this.tsCancelar.Click += new System.EventHandler(this.tsCancelar_Click);
            // 
            // tsRegistrar
            // 
            this.tsRegistrar.Name = "tsRegistrar";
            this.tsRegistrar.Size = new System.Drawing.Size(155, 25);
            this.tsRegistrar.Text = "REGISTRAR LLAMDA";
            this.tsRegistrar.Click += new System.EventHandler(this.tsRegistrar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(30, 25);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(51, 25);
            this.tsSalir.Text = "SALIR";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(495, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 23);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Ejercicio_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvLlamadas);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_7";
            this.Text = "Ejercicio_7";
            this.Load += new System.EventHandler(this.Ejercicio_7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvLlamadas;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmInternacional;
        private System.Windows.Forms.RadioButton rbmNacional;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.RadioButton rbInternacional;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsRegistrar;
        private System.Windows.Forms.ToolStripLabel toolStripButton2;
        private System.Windows.Forms.ToolStripLabel tsCancelar;
        private System.Windows.Forms.ToolStripLabel tsSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button btnActualizar;
    }
}