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
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(SportAPIDbContext context) : base(context)
        {
        }
    }
}
