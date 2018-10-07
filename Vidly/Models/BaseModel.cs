using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class BaseModel
    {
        public int ID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}