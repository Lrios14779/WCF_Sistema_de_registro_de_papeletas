//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Final_01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Agente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Agente()
        {
            this.Tb_Papeleta = new HashSet<Tb_Papeleta>();
        }
    
        public string Cod_Agente { get; set; }
        public string Nom_Agente { get; set; }
        public string Ape_Agente { get; set; }
        public string Cod_Distrito { get; set; }
    
        public virtual Tb_Distrito Tb_Distrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Papeleta> Tb_Papeleta { get; set; }
    }
}
