//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _07_MvcOA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActionInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActionInfo()
        {
            this.R_UserInfo_ActionInfo = new HashSet<R_UserInfo_ActionInfo>();
            this.RoleInfo = new HashSet<RoleInfo>();
            this.Department = new HashSet<Department>();
        }
    
        public int ID { get; set; }
        public System.DateTime SubTime { get; set; }
        public short DelFlag { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string Remark { get; set; }
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public string ActionMethodName { get; set; }
        public string ControllerName { get; set; }
        public string ActionInfoName { get; set; }
        public string Sort { get; set; }
        public short ActionTypeEnum { get; set; }
        public string MenuIcon { get; set; }
        public int IconWidth { get; set; }
        public int IconHeight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleInfo> RoleInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Department { get; set; }
    }
}
