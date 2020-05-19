using ComputerNet.DAL.Entities;
using Microsoft.AspNet.Identity;

namespace ComputerNet.DAL.Repositories
{
    public class ApplicationUserManager : UserManager<User>
    {
        public ApplicationUserManager(IUserStore<User> store)
            : base(store)
        {
        }

    }
}
