using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {           
            db.UserTypes.Add(new UserType { TypeName = "Друзья" });
            db.UserTypes.Add(new UserType { TypeName = "Коллеги" });
            db.UserTypes.Add(new UserType { TypeName = "Родственники" });

            db.Users.Add(new User { Name = "Елена", Surname = "Лищенко", Patronymic = "Владимировна", PhoneNumber="8(960)0000000", Email="Elena@mail.ru" });
            db.Users.Add(new User { Name = "Евгений", Surname = "Ладыко", Patronymic = "Евгеньевич", PhoneNumber = "8(960)0000000", Email = "Elena@mail.ru"});
            db.Users.Add(new User { Name = "Андрей", Surname = "Бекетов", Patronymic = "Андреевич", PhoneNumber = "8(960)0000000", Email = "Elena@mail.ru"});


            base.Seed(db);
        }
    }
}