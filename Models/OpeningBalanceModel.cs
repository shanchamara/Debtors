using System;
using System.Web.Mvc;

namespace AuditSystem.Models
{
    public class OpeningBalanceModel
    {
        public int Id { get; set; }
        public int Fk_CustomerId { get; set; }
        public string Narration { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; } = DateTime.Now;
        public Nullable<decimal> Amount { get; set; }
        public string SalesRep { get; set; }
        public bool IsDelete { get; set; }
        public string Create_By { get; set; }
        public System.DateTime Create_Date { get; set; }
        public string Edit_By { get; set; }
        public Nullable<System.DateTime> Edit_Date { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Date { get; set; }

        public SelectList CustomerLists { get; set; }
    }
}