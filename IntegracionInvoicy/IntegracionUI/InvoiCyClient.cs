using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IntegracionUI
{
    public class InvoiCyClient
    {
        public InvoiCyClient() { }

        //atributos privados
        private string? UrlWs { get; set; }
        private string? Soap { get; set; }
        private string? SoapRet { get; set; }

        //atributos públicos de salida
        public int ErrorCode { get; set; }
        public string? ErrorDesc { get; set; }

        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();


        public string GeneraEncabezado(Dictionary<string, string> datos, int tipo)
        {
            StringBuilder sb = new();

            sb.Append($"&lt;Encabezado&gt;");
            if (tipo != 11) sb.Append($"&lt;EmpCodigo&gt;{datos["EmpCodigo"]}&lt;/EmpCodigo&gt;");
            sb.Append($"&lt;EmpPK&gt;{datos["EmpPK"]}&lt;/EmpPK&gt;");
            sb.Append($"&lt;EmpCK&gt;{datos["EmpCK"]}&lt;/EmpCK&gt;");
            if (tipo == 15 || tipo == 16) sb.Append($"&lt;Pagina&gt;{datos["Pagina"]}&lt;/Pagina&gt;"); //Informa la pagina deseada. Si no informado retorna pagina 1
            sb.Append($"&lt;/Encabezado&gt;");

            return sb.ToString();
        }


        // Función que realiza la escritura SOAP
        public void GeneraSoap(Dictionary<string,string> datos, int tipo)
        {
            var URL = datos["Ambiente"] == "Pruebas" ? URL_Pruebas : URL_Producion; 
            UrlWs = $"{URL[tipo]}?wsdl";
            var encabezado = GeneraEncabezado(datos, tipo);

            // Linealizar el XML del documento        
            datos["XML"] = datos["XML"].Replace("(?ism)(?<=>)[^a-z|0-9]*(?=<)","");

            // Convierte el xml del documento a texto
            string XmlEnvio = datos["XML"];
	        XmlEnvio = XmlEnvio.Replace("<","&lt;");
	        XmlEnvio = XmlEnvio.Replace(">","&gt;");
	        XmlEnvio = XmlEnvio.Replace("\"","&quot;");

            StringBuilder sb = new();

            sb.Append("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:gx=\"Gx\">");
            sb.Append(  "<soapenv:Header/>");
            sb.Append(  "<soapenv:Body>");
            sb.Append($"<gx:{ExecuteTipo[tipo]}.Execute>");
            sb.Append($"<gx:{XmlTipo[tipo]}>&lt;{ServicoTipo[tipo]}&gt;");
            sb.Append(encabezado);
            sb.Append(XmlEnvio);
            sb.Append($"&lt;/{ServicoTipo[tipo]}&gt;</gx:{XmlTipo[tipo]}>");
            sb.Append(      $"</gx:{ExecuteTipo[tipo]}.Execute>");
            sb.Append(  "</soapenv:Body>");
            sb.Append("</soapenv:Envelope>");

            Soap = sb.ToString();
        }

        public async Task EjecutaWSAsync()
        {
            // Realiza la solicitud a invoiCy
            try
            {
                HttpContent content = new StringContent(Soap, Encoding.UTF8, "text/xml");
                HttpResponseMessage response = await client.PostAsync(UrlWs, content);

                // Comprobar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer la respuesta como una string
                    string responseContent = await response.Content.ReadAsStringAsync();
                    SoapRet = responseContent.Trim().Replace("\n", "").Replace("\t", "");

                }
                else
                {
                    Console.WriteLine($"Erro na solicitação: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            // solicitud fallida
            catch (Exception exc)
            {
                ErrorCode = 999;
                SoapRet = exc.Message + exc.StackTrace;
            }
        }


        public string? GetSoapRet() 
        {
            string? XmlRespuesta = SoapRet;
            XmlRespuesta = XmlRespuesta?.Replace("&lt;", "<");
            XmlRespuesta = XmlRespuesta?.Replace("&gt;", ">");
            XmlRespuesta = XmlRespuesta?.Replace("&quot;", "\"");
            return XmlRespuesta; 
        }

        private string[] ServicoTipo =
        {
            $"EnvioCFE",
            "ConsultaCFE",
            "Anulacion",
            "ConsultaCFERecibidos",
            "DescargaCFERecibidos",
            "AceptacionCFERecibidos",
            "ConsultaDatosGenerales",
            "ValidacionCFE",
            "ImpresionDelSocio",
            "ConsultaRUT",
            "ConsultaReporteDiario",
            "RegistroEmpresa",
            "RegistroCAE",
            "ConsultaNotificaciones",
            "Impresion",
            "DescargaEmitidos",
            "ConsultaItem",
            "ConsultaCertificado",
        };

        private string[] ExecuteTipo =
        {
            "WS_EmissionFactura",
            "WS_ConsultaFactura",
            "WS_Anulacion",
            "WS_ConsultaRecibidos",
            "WS_DescargaRecibidos",
            "WS_AceptacionRecibidos",
            "WS_ConsultaDatosGenerales",
            "WS_Validacion",
            "WS_ImpresionDelSocio",
            "WS_ConsultaRut",
            "WS_ConsultaReporteDiario",
            "WS_RegistroEmpresa",
            "WS_RegistroCAE",
            "WS_ConsultaNotificaciones",
            "WS_Impresion",
            "WS_DescargaEmitidos",
            "WS_ConsultaItems",
            "WS_ConsultaEmpresas",
        };
        private string[] XmlTipo =
        {
            "Xmlrecepcao",
            "Xmlconsulta",
            "Xmlanulacion",
            "Xmlconsulta",
            "Xmldescarga",
            "Xmlaceptacion",
            "Xmlconsultadatosgenerales",
            "Xmlvalidacion",
            "Xmlenvio",
            "Xmlenvio",
            "Xmlenvio",
            "Xmlenvio",
            "Xmlenvio",
            "Xmlenvio",
            "Xmlenvio",
            "Xmldescarga",
            "Xmlconsulta",
            "Xmlconsulta",
        };

        private string[] URL_Pruebas =
        {
            "https://appuypruebas.migrate.info/InvoiCy/aws_emissionfactura.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultafactura.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_anulacion.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultarecibidos.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_descargarecibidos.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_aceptacionrecibidos.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultadatosgenerales.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_validacion.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_impresiondelsocio.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultarut.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultareportediario.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_registroempresa.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_registrocae.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultanotificaciones.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_impresion.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_descargaemitidos.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultaitems.aspx",
            "https://appuypruebas.migrate.info/InvoiCy/aws_consultaempresas.aspx",
        };


        private string[] URL_Producion =
        {
            "https://appuy.migrate.info/InvoiCy/aws_emissionfactura.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultafactura.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_anulacion.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultarecibidos.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_descargarecibidos.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_aceptacionrecibidos.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultadatosgenerales.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_validacion.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_impresiondelsocio.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultarut.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultareportediario.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_registroempresa.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_registrocae.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultanotificaciones.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_impresion.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_descargaemitidos.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultaitems.aspx",
            "https://appuy.migrate.info/InvoiCy/aws_consultaempresas.aspx",
        };



    }
}