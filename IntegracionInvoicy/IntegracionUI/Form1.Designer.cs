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
            SuspendLayout();
            // 
            // btnExecutarManual
            // 
            btnExecutarManual.Location = new Point(286, 61);
            btnExecutarManual.Margin = new Padding(3, 2, 3, 2);
            btnExecutarManual.Name = "btnExecutarManual";
            btnExecutarManual.Size = new Size(200, 22);
            btnExecutarManual.TabIndex = 3;
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
            txtClavePartner.TabIndex = 0;
            txtClavePartner.TextChanged += txtClavePartner_TextChanged;
            // 
            // txtClaveAcceso
            // 
            txtClaveAcceso.Location = new Point(11, 34);
            txtClaveAcceso.Margin = new Padding(3, 2, 3, 2);
            txtClaveAcceso.Name = "txtClaveAcceso";
            txtClaveAcceso.PlaceholderText = "Clave de Acceso (EmpCO)";
            txtClaveAcceso.Size = new Size(679, 23);
            txtClaveAcceso.TabIndex = 1;
            txtClaveAcceso.TextChanged += txtClaveAcceso_TextChanged;
            // 
            // comboBoxOpcion
            // 
            comboBoxOpcion.DisplayMember = "0";
            comboBoxOpcion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOpcion.FormattingEnabled = true;
            comboBoxOpcion.Location = new Point(12, 61);
            comboBoxOpcion.Margin = new Padding(3, 2, 3, 2);
            comboBoxOpcion.Name = "comboBoxOpcion";
            comboBoxOpcion.Size = new Size(269, 23);
            comboBoxOpcion.TabIndex = 2;
            comboBoxOpcion.SelectedIndexChanged += comboBoxOpcion_SelectedIndexChanged;
            // 
            // richTxtRespuesta
            // 
            richTxtRespuesta.Location = new Point(14, 436);
            richTxtRespuesta.Name = "richTxtRespuesta";
            richTxtRespuesta.ReadOnly = true;
            richTxtRespuesta.Size = new Size(678, 319);
            richTxtRespuesta.TabIndex = 5;
            richTxtRespuesta.Text = "";
            // 
            // richTxtXML
            // 
            richTxtXML.Location = new Point(14, 89);
            richTxtXML.Name = "richTxtXML";
            richTxtXML.Size = new Size(678, 277);
            richTxtXML.TabIndex = 5;
            richTxtXML.Text = "<CFE> . . . </CFE>";
            richTxtXML.Click += richTxtXML_Click;
            richTxtXML.TextChanged += richTxtXML_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 375);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Retorno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 395);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(92, 392);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(76, 23);
            txtCodigo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 395);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Mensagem:";
            // 
            // txtMensage
            // 
            txtMensage.Location = new Point(260, 392);
            txtMensage.Name = "txtMensage";
            txtMensage.ReadOnly = true;
            txtMensage.Size = new Size(432, 23);
            txtMensage.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 418);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Documento:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 765);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}