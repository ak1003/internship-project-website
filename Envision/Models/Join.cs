//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Envision.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Join
    {
        public string S_Id { get; set; }
        public string P_Id { get; set; }
        public string Status { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Student Student { get; set; }
    }
}
