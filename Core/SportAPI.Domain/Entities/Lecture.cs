using SportAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Domain.Entities
{
    public class Lecture:BaseEntity
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string LectureName { get; set; }
        public string LiveUrl { get; set; }
        public Category Category { get; set; }
        public ICollection<LectureUser> LectureUsers { get; set; }

    }
}
