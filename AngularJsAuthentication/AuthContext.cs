using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularJsAuthentication.API
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}