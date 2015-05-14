using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Frete4U.Models;

namespace Frete4U.ViewModels
{
    public class BuscarView
    {
        public ICollection<tb_cd_cidades> Cidades { get; set; }
        public ICollection<tb_cd_tipo_entrega> TiposEntrega { get; set; }
        public ICollection<tb_cd_transporte> Trasportes { get; set; }
        public ICollection<RegisterViewModel> Usuarios { get; set; }
        public string teste { get; set; }
    }
}