using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models.Dto
{
    public class CustomerDto : BaseModel
    {
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? DOB { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}