using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }


    [WebMethod]
    public String fibonormal(int n)
    {
        //return ClassLibrary1fibonacci.Say.fibobonormal(n);
        //return ClassLibrary1fibonacci.Say.suma(n , x);
        return ClassLibrary1fibonacci.Say.fiboestructurado(n);
            
    }

    [WebMethod]
    public String fiboStructurado(int n)
    {
        //return ClassLibrary1fibonacci.Say.fibobonormal(n);
        //return ClassLibrary1fibonacci.Say.suma(n , x);
        return ClassLibrary1fibonacci.Say.fiboestructurado(n);

    }




}
