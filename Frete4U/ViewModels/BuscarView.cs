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
        public IEnumerable<tb_cd_cidades> Cidades { get; set; }
        public IEnumerable<tb_cd_tipo_entrega> TiposEntrega { get; set; }
        public IEnumerable<tb_cd_transporte> Trasportes { get; set; }
        public IEnumerable<ApplicationUser> Usuarios { get; set; }
        public string teste { get; set; }
    }
}