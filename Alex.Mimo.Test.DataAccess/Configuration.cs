using System.Data.Entity.Migrations;
using Alex.Mimo.Test.DataAccess.Contexts;

namespace Alex.Mimo.Test.DataAccess
{
    internal sealed class Configuration : DbMigrationsConfiguration<MimoContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }
    }
}