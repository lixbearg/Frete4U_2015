//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Frete4U.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cd_tipo_entrega
    {
        public tb_cd_tipo_entrega()
        {
            this.tb_cd_transporte = new HashSet<tb_cd_transporte>();
            this.tb_cd_prestador = new HashSet<tb_cd_prestador>();
        }
    
        public int cod_entrega { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<tb_cd_transporte> tb_cd_transporte { get; set; }
        public virtual ICollection<tb_cd_prestador> tb_cd_prestador { get; set; }
    }
}