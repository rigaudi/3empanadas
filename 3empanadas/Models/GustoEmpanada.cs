//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3empanadas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GustoEmpanada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GustoEmpanada()
        {
            this.InvitacionPedidoGustoEmpanadaUsuario = new HashSet<InvitacionPedidoGustoEmpanadaUsuario>();
            this.Pedido = new HashSet<Pedido>();
        }
    
        public int IdGustoEmpanada { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvitacionPedidoGustoEmpanadaUsuario> InvitacionPedidoGustoEmpanadaUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
