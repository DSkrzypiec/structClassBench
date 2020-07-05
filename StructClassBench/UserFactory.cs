using System;
using System.Collections.Generic;
using StructClassBench.Models;

namespace StructClassBench
{
    public class UserFactory
    {
        public IEnumerable<UserStruct> PopulateUserStructs(int size)
        {
            var rand = new Random();
            for (var i = 0; i < size; i++)
            {
                yield return new UserStruct
                {
                    UserId = (long)i,
                    UserNameId = i + 18,
                    UserAge = rand.Next(18, 65),
                    UserAccountValue = (decimal)(i / 0.123 + 12313.123)
                };
            }
        }

        public IEnumerable<UserClass> PopulateUserClasses(int size)
        {
            var rand = new Random();
            for (var i = 0; i < size; i++)
            {
                yield return new UserClass
                {
                    UserId = (long)i,
                    UserNameId = i + 18,
                    UserAge = rand.Next(18, 65),
                    UserAccountValue = (decimal)(i / 0.123 + 12313.123)
                };
            }
        }

        public IEnumerable<IUser> PopulateUserStructsAsIUsers(int size)
        {
            var rand = new Random();
            for (var i = 0; i < size; i++)
            {
                yield return new UserStruct
                {
                    UserId = (long)i,
                    UserNameId = i + 18,
                    UserAge = rand.Next(18, 65),
                    UserAccountValue = (decimal)(i / 0.123 + 12313.123)
                };
            }
        }

        public IEnumerable<IUser> PopulateUserClassesAsIUser(int size)
        {
            var rand = new Random();
            for (var i = 0; i < size; i++)
            {
                yield return new UserClass
                {
                    UserId = (long)i,
                    UserNameId = i + 18,
                    UserAge = rand.Next(18, 65),
                    UserAccountValue = (decimal)(i / 0.123 + 12313.123)
                };
            }
        }
    }
}
