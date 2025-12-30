using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin.DAL
{
    public static class UserRepositoryFactory
    {
        public static UserRepository Create(RepositoryType type,ApplicationDbContext context)
        {
            switch (type)
            {
                case RepositoryType.StoredProcedure:
                    return new UserRepositorySPImpl();
                case RepositoryType.Sql:
                    return new UserRepositoryImpl();
                case RepositoryType.Linq:
                    return new UserRepositoryLinq(context);
                default:
                    return new UserRepositoryImpl();
            }
        }
    }
}
