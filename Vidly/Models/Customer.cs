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
    }
}