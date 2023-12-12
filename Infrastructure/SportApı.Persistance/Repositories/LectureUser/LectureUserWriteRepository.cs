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
    public class LectureUserWriteRepository : WriteRepository<LectureUser>, ILectureUserWriteRepository
    //WriteRepository<LectureUser>,ILectureUserWriteRepository'nin uygulanmasıdır.ILectureUserWriteRepository sadece bir imzadır bunun içi WriteRepository<LectureUser> bunula doldurulur işlemler yapılır yani
    {
        public LectureUserWriteRepository(SportAPIDbContext context) : base(context)
        {
        }
    }
}
