//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Esubao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class transportation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transportation()
        {
            this.Fahuos = new HashSet<Fahuo>();
            this.orders = new HashSet<order>();
        }
    
        public int id { get; set; }
        public string Type_shipping { get; set; }
        public string Durationf_transportation { get; set; }
        public string Starting_price { get; set; }
        public string Heavy_cargo { get; set; }
        public string Light__goods { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fahuo> Fahuos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
