﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWebELAPAS
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        

        [WebMethod]
        public Double getDeudaELAPAS(int i)
        {
            switch (i)
            {
                case 1: 
                    return 50;
                case 2: 
                    return 25;
                case 3: 
                    return 75;
                case 4:
                    return 100;
                case 5: 
                    return 50;

            }
            return 0;
        }
    }
}
