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
    
    public partial class Tb_Auto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Auto()
        {
            this.Tb_Papeleta = new HashSet<Tb_Papeleta>();
        }
    
        public string Num_Placa { get; set; }
        public Nullable<int> Año { get; set; }
        public string Cod_Marca { get; set; }
        public string Cod_Color { get; set; }
        public string Cod_Propietario { get; set; }
    
        public virtual Tb_Color Tb_Color { get; set; }
        public virtual Tb_Marca Tb_Marca { get; set; }
        public virtual Tb_Propietario Tb_Propietario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Papeleta> Tb_Papeleta { get; set; }
    }
}
