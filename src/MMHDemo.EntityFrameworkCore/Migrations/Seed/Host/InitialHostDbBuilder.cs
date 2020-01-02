using Acme.PhoneBookDemo.Migrations.Seed.Host;
using MMHDemo.EntityFrameworkCore;

namespace MMHDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly MMHDemoDbContext _context;

        public InitialHostDbBuilder(MMHDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            new InitialPeopleCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
