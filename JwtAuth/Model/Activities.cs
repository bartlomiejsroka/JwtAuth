//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JwtAuth.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activities
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> StopTime { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}
