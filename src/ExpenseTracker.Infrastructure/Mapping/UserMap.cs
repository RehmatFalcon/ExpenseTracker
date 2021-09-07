using ExpenseTracker.Authentication.Entities;
using FluentNHibernate.Mapping;

namespace ExpenseTracker.Infrastructure.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("user");
            Id(a => a.Id).Column("user_id");
            Map(a => a.FirstName).Column("first_name").CustomSqlType("varchar(50)");
            Map(a => a.LastName).Column("last_name").CustomSqlType("varchar(50)");
            Map(a => a.Username).Column("user_name").CustomSqlType("varchar(50)");
            Map(a => a.Password).Column("password").CustomSqlType("varchar(50)");
        }
    }
}