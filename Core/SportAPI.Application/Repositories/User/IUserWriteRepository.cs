using SportAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Application.Repositories
{
    public interface IUserWriteRepository:IWriteRepository<User>
    {
    }
}
