//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatBot
{
    using System;
    using System.Collections.Generic;
    
    public partial class respuesta
    {
        public int idrespuesta { get; set; }
        public string descripcion { get; set; }
        public int idpregunta { get; set; }
    
        public virtual pregunta pregunta { get; set; }
    }
}
