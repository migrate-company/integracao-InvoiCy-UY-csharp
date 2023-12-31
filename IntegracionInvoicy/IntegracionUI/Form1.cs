using EmissionFactura;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.Design.AxImporter;

namespace IntegracionUI
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> Datos;

        private OpcionIntegracion Opcion;

        private string Ambiente;

        public Form1()
        {
            InitializeComponent();
            comboBoxOpcion.DataSource = Enum.GetValues(typeof(OpcionIntegracion));
            comboBoxOpcion.SelectedIndex = -1;
            btnExecutarManual.Enabled = false;

            Datos = new Dictionary<string, string>
            {
                { "EmpPK", "" }, // Clave de Socio (Inicio->Panel de control->Socios)
                { "ClaveAcceso", "" }, // Clave de Acceso (Inicio->Panel de control->Datos de la Sucursal->Ver la clave de acceso)
                { "EmpCodigo", "" }, // C�digo de integraci�n (Inicio->Panel de control->Datos de la Sucursal->C�digo de integraci�n)
                { "EmpCK", "" },
                { "XML", "" },
                { "Pagina", ""},
                { "Ambiente", "Pruebas"}
            };
        }


        private async void btnExecutarManual_Click(object sender, EventArgs e)
        {
            //Gera CK
            if ((int)Opcion == 11)
            {
                Datos["EmpCK"] = GeneraHashMD5(Datos["EmpPK"] + Datos["XML"]);
            }
            else
            {
                Datos["EmpCK"] = GeneraHashMD5(Datos["ClaveAcceso"] + Datos["XML"]);
            }

            var tipo = Enum.GetName(typeof(OpcionIntegracion), Opcion);

            var clientUY = new InvoiCyClient();
            clientUY.GeneraSoap(Datos, (int)Opcion);
            await clientUY.EjecutaWSAsync();

            var respuesta = clientUY.GetSoapRet();

            //Busca o c�digo e a descri��o de retorno.
            if (respuesta is not null && respuesta.Contains("</MsgDsc>"))
            {
                txtMensage.Text = respuesta.Substring(respuesta.IndexOf("<MsgDsc>"), respuesta.IndexOf("</MsgDsc>") - respuesta.IndexOf("<MsgDsc>")).Replace("<MsgDsc>", "");
            }
            else txtMensage.Text = "";

            if (respuesta is not null && respuesta.Contains("</MsgCod>"))
            {
                txtCodigo.Text = respuesta.Substring(respuesta.IndexOf("<MsgCod>"), respuesta.IndexOf("</MsgCod>") - respuesta.IndexOf("<MsgCod>")).Replace("<MsgCod>", "");
            }
            else txtCodigo.Text = "";

            if (respuesta is not null && respuesta.Contains($"</{tipo}Retorno>"))
            {
                var resp = respuesta.Substring(respuesta.IndexOf($"<{tipo}Retorno>"), respuesta.IndexOf($"</{tipo}Retorno>") - respuesta.IndexOf($"<{tipo}Retorno>") + tipo.Length + 10);
                richTxtRespuesta.Text = XDocument.Parse(resp).ToString();
            }
            else richTxtRespuesta.Text = respuesta;

        }

        //Funci�n que genera un hash MD5 de una string
        public static string GeneraHashMD5(string input)
        {
            using System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create();
            // input = "clave_de_acceso" + "<CFE>...</CFE>"
            byte[] data = md5Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));

            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void comboBoxOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = Enum.TryParse(comboBoxOpcion.SelectedValue?.ToString(), out Opcion);

            if (comboBoxOpcion.SelectedIndex == 15 || comboBoxOpcion.SelectedIndex == 16) { txtPagina.Enabled = true; }
            else { txtPagina.Enabled = false; }
        }

        private void txtClavePartner_TextChanged(object sender, EventArgs e)
        {
            Datos["EmpPK"] = txtClavePartner.Text;
            CanExecute();
        }

        private void txtClaveAcceso_TextChanged(object sender, EventArgs e)
        {
            Datos["ClaveAcceso"] = txtClaveAcceso.Text;
            CanExecute();
        }

        private void txtEmpCodigo_TextChanged(object sender, EventArgs e)
        {
            Datos["EmpCodigo"] = txtEmpCodigo.Text;
            CanExecute();
        }

        private void richTxtXML_TextChanged(object sender, EventArgs e)
        {
            Datos["XML"] = richTxtXML.Text.Trim();
            CanExecute();
        }

        private void CanExecute()
        {
            if (Datos["EmpPK"] != "" && Datos["ClaveAcceso"] != "" && Datos["XML"] != "")
            {
                btnExecutarManual.Enabled = true;
            }
            else
            {
                btnExecutarManual.Enabled = false;
            }
        }

        private void richTxtXML_Click(object sender, EventArgs e)
        {
            richTxtXML.Text = "";
        }


        private void checkBoxPruebas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPruebas.Checked)
            {
                Datos["Ambiente"] = "Pruebas";
                if (checkBoxProducion.Checked)
                    checkBoxProducion.Checked = false;
            }
            else
            {
                if (!checkBoxProducion.Checked)
                {
                    Datos["Ambiente"] = "Producion";
                    checkBoxProducion.Checked = true;
                }
            }
        }

        private void checkBoxProducion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProducion.Checked)
            {
                Datos["Ambiente"] = "Producion";
                if (checkBoxPruebas.Checked)
                    checkBoxPruebas.Checked = false;
            }
            else
            {
                if (!checkBoxPruebas.Checked)
                {
                    Datos["Ambiente"] = "Pruebas";
                    checkBoxPruebas.Checked = true;
                }
            }
        }

        private void txtPagina_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(txtPagina.Text))
            {
                txtPagina.Text = "";
            }

            Datos["Pagina"] = txtPagina.Text;
            CanExecute();
        }

        private void txtPagina_Click(object sender, EventArgs e)
        {
            txtPagina.Text = "";
        }
    }

    public enum OpcionIntegracion
    {
        [Display(Name = "Env�o de CFE")]
        EnvioCFE = 0,
        [Display(Name = "Consulta de CFE")]
        ConsultaCFE = 1,
        [Display(Name = "Anulaci�n de CFE")]
        Anulacion = 2,
        [Display(Name = "Consulta de CFE Recibidos")]
        ConsultaCFERecibidos = 3,
        [Display(Name = "Descarga de CFE Recibidos")]
        DescargaCFERecibidos = 4,
        [Display(Name = "Aceptaci�n de CFE Recibidos")]
        AceptacionCFERecibidos = 5,
        [Display(Name = "Consulta de Datos Generales")]
        ConsultaDatosGenerales = 6,
        [Display(Name = "Validaci�n de CFE")]
        ValidacionCFE = 7,
        [Display(Name = "Representaci�n Impresa del Socio")]
        ImpresionDelSocio = 8,
        [Display(Name = "Consulta de RUT")]
        ConsultaRUT = 9,
        [Display(Name = "Consulta de Datos Reporte Di�rio")]
        ConsultaReporteDiario = 10,
        [Display(Name = "Registro de Empresa")]
        RegistroEmpresa = 11,
        [Display(Name = "Registro de CAE")]
        RegistroCAE = 12,
        [Display(Name = "Consulta Notificaciones")]
        ConsultaNotificaciones = 13,
        [Display(Name = "Reimpresi�n de CFE")]
        Impresion = 14,
        [Display(Name = "Descarga de CFE Emitidos")]
        DescargaEmitidos = 15,
        [Display(Name = "Consulta de �tems")]
        ConsultaItem = 16,
        [Display(Name = "Consulta de Certificados Digitales")]
        ConsultaCertificado = 17,
    }
}