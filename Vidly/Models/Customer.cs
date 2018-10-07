using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer : BaseModel
    {
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? DOB { get; set; }
        public byte MembershipTypeId { get; set; }
        public virtual MembershipType MembershipType { get; set; }
    }
}