using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie : BaseModel
    {
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberInStock { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}