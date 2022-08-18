namespace ActividadParcial
{
    partial class FormPresentacion
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxDNI = new System.Windows.Forms.TextBox();
            this.btnAgregarPer = new System.Windows.Forms.Button();
            this.btnCalcEdad = new System.Windows.Forms.Button();
            this.lblEdadMostrada = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(117, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(141, 107);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(51, 153);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(117, 15);
            this.lblFechaNac.TabIndex = 2;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(258, 266);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(174, 58);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(100, 23);
            this.txtbxNombre.TabIndex = 4;
            // 
            // txtbxDNI
            // 
            this.txtbxDNI.Location = new System.Drawing.Point(174, 99);
            this.txtbxDNI.Name = "txtbxDNI";
            this.txtbxDNI.Size = new System.Drawing.Size(100, 23);
            this.txtbxDNI.TabIndex = 5;
            // 
            // btnAgregarPer
            // 
            this.btnAgregarPer.Location = new System.Drawing.Point(346, 79);
            this.btnAgregarPer.Name = "btnAgregarPer";
            this.btnAgregarPer.Size = new System.Drawing.Size(105, 31);
            this.btnAgregarPer.TabIndex = 7;
            this.btnAgregarPer.Text = "Agregar persona";
            this.btnAgregarPer.UseVisualStyleBackColor = true;
            this.btnAgregarPer.Click += new System.EventHandler(this.btnAgregarPer_Click);
            // 
            // btnCalcEdad
            // 
            this.btnCalcEdad.Enabled = false;
            this.btnCalcEdad.Location = new System.Drawing.Point(137, 259);
            this.btnCalcEdad.Name = "btnCalcEdad";
            this.btnCalcEdad.Size = new System.Drawing.Size(91, 29);
            this.btnCalcEdad.TabIndex = 8;
            this.btnCalcEdad.Text = "Calcular edad";
            this.btnCalcEdad.UseVisualStyleBackColor = true;
            this.btnCalcEdad.Click += new System.EventHandler(this.btnCalcEdad_Click);
            // 
            // lblEdadMostrada
            // 
            this.lblEdadMostrada.AutoSize = true;
            this.lblEdadMostrada.Location = new System.Drawing.Point(339, 263);
            this.lblEdadMostrada.Name = "lblEdadMostrada";
            this.lblEdadMostrada.Size = new System.Drawing.Size(0, 15);
            this.lblEdadMostrada.TabIndex = 9;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(174, 147);
            this.dtpFechaNac.MaxDate = new System.DateTime(2022, 8, 18, 13, 3, 7, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaNac.TabIndex = 10;
            this.dtpFechaNac.Value = new System.DateTime(2022, 8, 18, 0, 0, 0, 0);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(387, 231);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(75, 15);
            this.lblPrueba.TabIndex = 11;
            this.lblPrueba.Text = "Label Prueba";
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 374);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblEdadMostrada);
            this.Controls.Add(this.btnCalcEdad);
            this.Controls.Add(this.btnAgregarPer);
            this.Controls.Add(this.txtbxDNI);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormPresentacion";
            this.Text = "FormPresentacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDNI;
        private Label lblFechaNac;
        private Label lblEdad;
        private TextBox txtbxNombre;
        private TextBox txtbxDNI;
        private Button btnAgregarPer;
        private Button btnCalcEdad;
        private Label lblEdadMostrada;
        private DateTimePicker dtpFechaNac;
        private Label lblPrueba;
    }
}