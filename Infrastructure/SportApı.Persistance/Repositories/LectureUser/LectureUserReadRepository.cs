using SportAPI.Application.Repositories;
using SportAPI.Domain.Entities;
using SportAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Persistance.Repositories
{
    public class LectureUserReadRepository : ReadRepository<LectureUser>, ILectureUserReadRepository
    {
        public LectureUserReadRepository(SportAPIDbContext context) : base(context)
        {
        }
    }
}
