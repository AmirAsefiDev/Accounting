//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounting
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int TypeID { get; set; }
        public long Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime DateTitle { get; set; }
    
        public virtual Accounting_Types Accounting_Types { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
