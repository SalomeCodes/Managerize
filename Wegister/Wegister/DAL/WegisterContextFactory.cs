using Microsoft.EntityFrameworkCore;
using Wegister.DAL;

namespace Wegister
{
    public class WegisterContextFactory : WegisterFactoryBase<WegisterContext>
    {
        protected override WegisterContext CreateNewInstance(
            DbContextOptions<WegisterContext> options)
        {
            return new WegisterContext(options);
        }
    }
}
