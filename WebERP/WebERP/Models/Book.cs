using System;
using System.Collections.Generic;

namespace WebERP.Models
{
    public partial class Book: BaseEntity
    {
        
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Publisher { get; set; }

        public virtual Author Author
        {
            get;
            set;
        }
    }
}
