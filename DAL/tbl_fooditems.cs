//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_fooditems
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public byte Status { get; set; }
        public byte IsSpecial { get; set; }
        public string Discount { get; set; }
        public string ImageUrl { get; set; }
        public string FoodName { get; set; }
    }
}
