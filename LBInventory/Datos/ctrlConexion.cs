//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ctrlConexion
    {
        public int Id { get; set; }
        public int TipoConexionId { get; set; }
        public string Servidor { get; set; }
        public string BaseDatos { get; set; }
        public Nullable<int> Puerto { get; set; }
        public int NumEmpresa { get; set; }
        public string Empresa { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public bool SNActivo { get; set; }
        public bool SNImportadora { get; set; }
        public bool SNComercializadora { get; set; }
        public virtual catTipoConexion catTipoConexion { get; set; }
    }
}
