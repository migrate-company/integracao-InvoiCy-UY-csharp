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
            txtEmpCodigo = new TextBox();
            txtPagina = new TextBox();
            SuspendLayout();
            // 
            // btnExecutarManual
            // 
            btnExecutarManual.Location = new Point(286, 97);
            btnExecutarManual.Margin = new Padding(3, 2, 3, 2);
            btnExecutarManual.Name = "btnExecutarManual";
            btnExecutarManual.Size = new Size(200, 22);
            btnExecutarManual.TabIndex = 5;
            btnExecutarManual.Text = "Ejecutar";
            btnExecutarManual.UseVisualStyleBackColor = true;
            btnExecutarManual.Click += btnExecutarManual_Click;
            // 
            // txtClavePartner
            // 
            txtClavePartner.Location = new Point(11, 10);
            txtClavePartner.Margin = new Padding(3, 2, 3, 2);
            txtClavePartner.Name = "txtClavePartner";
            txtClavePartner.PlaceholderText = "Clave de Partner (EmpPK)";
            txtClavePartner.Size = new Size(677, 23);
            txtClavePartner.TabIndex = 1;
            txtClavePartner.TextChanged += txtClavePartner_TextChanged;
            // 
            // txtClaveAcceso
            // 
            txtClaveAcceso.Location = new Point(11, 34);
            txtClaveAcceso.Margin = new Padding(3, 2, 3, 2);
            txtClaveAcceso.Name = "txtClaveAcceso";
            txtClaveAcceso.PlaceholderText = "Clave de Acceso";
            txtClaveAcceso.Size = new Size(679, 23);
            txtClaveAcceso.TabIndex = 2;
            txtClaveAcceso.TextChanged += txtClaveAcceso_TextChanged;
            // 
            // comboBoxOpcion
            // 
            comboBoxOpcion.DisplayMember = "0";
            comboBoxOpcion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOpcion.FormattingEnabled = true;
            comboBoxOpcion.Location = new Point(11, 98);
            comboBoxOpcion.Margin = new Padding(3, 2, 3, 2);
            comboBoxOpcion.Name = "comboBoxOpcion";
            comboBoxOpcion.Size = new Size(202, 23);
            comboBoxOpcion.TabIndex = 0;
            comboBoxOpcion.SelectedIndexChanged += comboBoxOpcion_SelectedIndexChanged;
            // 
            // richTxtRespuesta
            // 
            richTxtRespuesta.Location = new Point(14, 453);
            richTxtRespuesta.Name = "richTxtRespuesta";
            richTxtRespuesta.ReadOnly = true;
            richTxtRespuesta.Size = new Size(678, 300);
            richTxtRespuesta.TabIndex = 10;
            richTxtRespuesta.Text = "";
            // 
            // richTxtXML
            // 
            richTxtXML.Location = new Point(14, 126);
            richTxtXML.Name = "richTxtXML";
            richTxtXML.Size = new Size(678, 250);
            richTxtXML.TabIndex = 4;
            richTxtXML.Text = "<CFE> . . . </CFE>";
            richTxtXML.Click += richTxtXML_Click;
            richTxtXML.TextChanged += richTxtXML_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 389);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 10;
            label1.Text = "Retorno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 409);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(92, 406);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(76, 23);
            txtCodigo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 409);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 12;
            label3.Text = "Mensagem:";
            // 
            // txtMensage
            // 
            txtMensage.Location = new Point(260, 406);
            txtMensage.Name = "txtMensage";
            txtMensage.ReadOnly = true;
            txtMensage.Size = new Size(432, 23);
            txtMensage.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 432);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Documento:";
            // 
            // checkBoxPruebas
            // 
            checkBoxPruebas.AutoSize = true;
            checkBoxPruebas.Checked = true;
            checkBoxPruebas.CheckState = CheckState.Checked;
            checkBoxPruebas.Location = new Point(499, 100);
            checkBoxPruebas.Margin = new Padding(3, 2, 3, 2);
            checkBoxPruebas.Name = "checkBoxPruebas";
            checkBoxPruebas.Size = new Size(68, 19);
            checkBoxPruebas.TabIndex = 6;
            checkBoxPruebas.Text = "Pruebas";
            checkBoxPruebas.UseVisualStyleBackColor = true;
            checkBoxPruebas.CheckedChanged += checkBoxPruebas_CheckedChanged;
            // 
            // checkBoxProducion
            // 
            checkBoxProducion.AutoSize = true;
            checkBoxProducion.Location = new Point(588, 100);
            checkBoxProducion.Margin = new Padding(3, 2, 3, 2);
            checkBoxProducion.Name = "checkBoxProducion";
            checkBoxProducion.Size = new Size(87, 19);
            checkBoxProducion.TabIndex = 7;
            checkBoxProducion.Text = "Producción";
            checkBoxProducion.UseVisualStyleBackColor = true;
            checkBoxProducion.CheckedChanged += checkBoxProducion_CheckedChanged;
            // 
            // txtEmpCodigo
            // 
            txtEmpCodigo.Location = new Point(11, 61);
            txtEmpCodigo.Margin = new Padding(3, 2, 3, 2);
            txtEmpCodigo.Name = "txtEmpCodigo";
            txtEmpCodigo.PlaceholderText = "Código de integración (EmpCodigo)";
            txtEmpCodigo.Size = new Size(679, 23);
            txtEmpCodigo.TabIndex = 3;
            txtEmpCodigo.TextChanged += txtEmpCodigo_TextChanged;
            // 
            // txtPagina
            // 
            txtPagina.Enabled = false;
            txtPagina.Location = new Point(219, 98);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(61, 23);
            txtPagina.TabIndex = 14;
            txtPagina.Click += txtPagina_Click;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 765);
            Controls.Add(txtPagina);
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
            Controls.Add(txtEmpCodigo);
            Controls.Add(txtClaveAcceso);
            Controls.Add(txtClavePartner);
            Controls.Add(btnExecutarManual);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Integración Web Service InvoiCy UY";
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
        private TextBox txtEmpCodigo;
        private TextBox txtPagina;
    }
}