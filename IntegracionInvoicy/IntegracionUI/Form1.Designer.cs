namespace IntegracionUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExecutarManual = new Button();
            txtClavePartner = new TextBox();
            txtClaveAcceso = new TextBox();
            comboBoxOpcion = new ComboBox();
            richTxtRespuesta = new RichTextBox();
            richTxtXML = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtMensage = new TextBox();
            label4 = new Label();
            checkBoxPruebas = new CheckBox();
            checkBoxProducion = new CheckBox();
            SuspendLayout();
            // 
            // btnExecutarManual
            // 
            btnExecutarManual.Location = new Point(327, 81);
            btnExecutarManual.Name = "btnExecutarManual";
            btnExecutarManual.Size = new Size(229, 29);
            btnExecutarManual.TabIndex = 3;
            btnExecutarManual.Text = "Ejecutar";
            btnExecutarManual.UseVisualStyleBackColor = true;
            btnExecutarManual.Click += btnExecutarManual_Click;
            // 
            // txtClavePartner
            // 
            txtClavePartner.Location = new Point(13, 13);
            txtClavePartner.Name = "txtClavePartner";
            txtClavePartner.PlaceholderText = "Clave de Partner (EmpPK)";
            txtClavePartner.Size = new Size(773, 27);
            txtClavePartner.TabIndex = 0;
            txtClavePartner.TextChanged += txtClavePartner_TextChanged;
            // 
            // txtClaveAcceso
            // 
            txtClaveAcceso.Location = new Point(13, 45);
            txtClaveAcceso.Name = "txtClaveAcceso";
            txtClaveAcceso.PlaceholderText = "Clave de Acceso (EmpCO)";
            txtClaveAcceso.Size = new Size(775, 27);
            txtClaveAcceso.TabIndex = 1;
            txtClaveAcceso.TextChanged += txtClaveAcceso_TextChanged;
            // 
            // comboBoxOpcion
            // 
            comboBoxOpcion.DisplayMember = "0";
            comboBoxOpcion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOpcion.FormattingEnabled = true;
            comboBoxOpcion.Location = new Point(14, 81);
            comboBoxOpcion.Name = "comboBoxOpcion";
            comboBoxOpcion.Size = new Size(307, 28);
            comboBoxOpcion.TabIndex = 2;
            comboBoxOpcion.SelectedIndexChanged += comboBoxOpcion_SelectedIndexChanged;
            // 
            // richTxtRespuesta
            // 
            richTxtRespuesta.Location = new Point(16, 581);
            richTxtRespuesta.Margin = new Padding(3, 4, 3, 4);
            richTxtRespuesta.Name = "richTxtRespuesta";
            richTxtRespuesta.ReadOnly = true;
            richTxtRespuesta.Size = new Size(774, 424);
            richTxtRespuesta.TabIndex = 5;
            richTxtRespuesta.Text = "";
            // 
            // richTxtXML
            // 
            richTxtXML.Location = new Point(16, 119);
            richTxtXML.Margin = new Padding(3, 4, 3, 4);
            richTxtXML.Name = "richTxtXML";
            richTxtXML.Size = new Size(774, 368);
            richTxtXML.TabIndex = 5;
            richTxtXML.Text = "<CFE> . . . </CFE>";
            richTxtXML.Click += richTxtXML_Click;
            richTxtXML.TextChanged += richTxtXML_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 500);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "Retorno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 527);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(105, 523);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(86, 27);
            txtCodigo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 527);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Mensagem:";
            // 
            // txtMensage
            // 
            txtMensage.Location = new Point(297, 523);
            txtMensage.Margin = new Padding(3, 4, 3, 4);
            txtMensage.Name = "txtMensage";
            txtMensage.ReadOnly = true;
            txtMensage.Size = new Size(493, 27);
            txtMensage.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 557);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 7;
            label4.Text = "Documento:";
            // 
            // checkBoxPruebas
            // 
            checkBoxPruebas.AutoSize = true;
            checkBoxPruebas.Checked = true;
            checkBoxPruebas.CheckState = CheckState.Checked;
            checkBoxPruebas.Location = new Point(572, 85);
            checkBoxPruebas.Name = "checkBoxPruebas";
            checkBoxPruebas.Size = new Size(83, 24);
            checkBoxPruebas.TabIndex = 8;
            checkBoxPruebas.Text = "Pruebas";
            checkBoxPruebas.UseVisualStyleBackColor = true;
            checkBoxPruebas.CheckedChanged += checkBoxPruebas_CheckedChanged;
            // 
            // checkBoxProducion
            // 
            checkBoxProducion.AutoSize = true;
            checkBoxProducion.Location = new Point(673, 85);
            checkBoxProducion.Name = "checkBoxProducion";
            checkBoxProducion.Size = new Size(98, 24);
            checkBoxProducion.TabIndex = 8;
            checkBoxProducion.Text = "Produción";
            checkBoxProducion.UseVisualStyleBackColor = true;
            checkBoxProducion.CheckedChanged += checkBoxProducion_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1020);
            Controls.Add(checkBoxProducion);
            Controls.Add(checkBoxPruebas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMensage);
            Controls.Add(txtCodigo);
            Controls.Add(richTxtXML);
            Controls.Add(richTxtRespuesta);
            Controls.Add(comboBoxOpcion);
            Controls.Add(txtClaveAcceso);
            Controls.Add(txtClavePartner);
            Controls.Add(btnExecutarManual);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecutarManual;
        private TextBox txtChaveParceiro;
        private TextBox tctChaveAcesso;
        private ComboBox comboBoxOpcion;
        private TextBox txtClavePartner;
        private TextBox txtClaveAcceso;
        private RichTextBox richTxtRespuesta;
        private RichTextBox richTxtXML;
        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtMensage;
        private Label label4;
        private CheckBox checkBoxPruebas;
        private CheckBox checkBoxProducion;
    }
}