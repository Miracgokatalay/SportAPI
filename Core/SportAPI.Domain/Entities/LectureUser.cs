using SportAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Domain.Entities
{
    public class LectureUser: BaseEntity
    {
        public int LectureId { get; set; }
        public int UserId { get; set; }
        public Lecture Lecture { get; set; }
        public User User { get; set; }
    }
}
