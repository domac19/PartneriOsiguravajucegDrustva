using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartneriOsiguravajućegDruštva.Models
{
    public class Partner
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int PartnerNumber { get; set; }

        public int CroatianPIN { get; set; }
        
        public int PartnerTypeId { get; set; }
        
        public DateTime CreatedAtUtc { get; set; }
        
        public string CreateByUser { get; set; }
        
        public bool IsForeign { get; set; }
        
        public int ExternalCode { get; set; }
        
        public byte Gender { get; set; }
        
        public string BrojPolice { get; set; }
        
        public decimal IznosPolice { get; set; }
    }
}