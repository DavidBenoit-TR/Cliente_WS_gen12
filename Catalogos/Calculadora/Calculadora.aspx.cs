using Cliente_WS_gen12.Calculadora_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_WS_gen12.Catalogos.Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {

        //creamos un clinete que resuelva las peticiones del servicio SOAP
        calculadora_ServiceSoapClient clientes_WS;
        protected void Page_Load(object sender, EventArgs e)
        {
            //inicializo mi clente SOAP
            clientes_WS = new calculadora_ServiceSoapClient();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco mi servicio pasando los datos que requiere
            double resultado = clientes_WS.Suma(a, b);
            //muestro el resultado del servicio en mi pagina
            lblresultado.Text = resultado.ToString();
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco mi servicio pasando los datos que requiere
            double resultado = clientes_WS.Resta(a, b);
            //muestro el resultado del servicio en mi pagina
            lblresultado.Text = resultado.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco mi servicio pasando los datos que requiere
            double resultado = clientes_WS.Multiplicacion(a, b);
            //muestro el resultado del servicio en mi pagina
            lblresultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco mi servicio pasando los datos que requiere
            double resultado = clientes_WS.Divicion(a, b);
            //muestro el resultado del servicio en mi pagina
            lblresultado.Text = resultado.ToString();
        }
    }
}