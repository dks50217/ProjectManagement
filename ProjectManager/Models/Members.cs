//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Members
    {
        public System.Guid MemberGUID { get; set; }
        public Nullable<System.Guid> EmployeeGUID { get; set; }
        public string MemberID { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<System.Guid> PermissionsGUID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Permissions Permissions { get; set; }
    }
}