using SportAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Lecture> Lectures { get; set;}
    }
}
