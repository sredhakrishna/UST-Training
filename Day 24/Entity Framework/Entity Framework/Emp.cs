//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual Dept Dept { get; set; }
    }
}
