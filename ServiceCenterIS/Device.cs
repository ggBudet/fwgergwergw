//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCenterIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.Registration_for_the_provision_of_services = new HashSet<Registration_for_the_provision_of_services>();
        }
    
        public int Id_device { get; set; }
        public int Id_type_device { get; set; }
        public string Name_device { get; set; }
        public string Serial_number { get; set; }
        public string Cause_of_failure { get; set; }
        public int Id_client { get; set; }
        public string Crash { get; set; }
        public Nullable<System.DateTime> Date_of_crash { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Type_device Type_device { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration_for_the_provision_of_services> Registration_for_the_provision_of_services { get; set; }
    }
}
