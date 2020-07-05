using System.Collections.Generic;
using System.Linq;

namespace StructClassBench.Calculators
{
    public class UserCalculator
    {
        private readonly IEnumerable<IUser> _users;
        private readonly List<IUser> _usersList;
        private readonly IUser[] _usersArray;

        public UserCalculator(IEnumerable<IUser> users)
        {
            _users = users;
            _usersList = users.ToList();
            _usersArray = users.ToArray();
        }

        public decimal SumAccountValue()
        {
            decimal sumAccountValue = 0m;
            foreach (var user in _users)
            {
                sumAccountValue += user.UserAccountValue;
            }
            return sumAccountValue;
        }

        public decimal SumAccountValueFromList()
        {
            decimal sumAccountValue = 0m;
            foreach (var user in _usersList)
            {
                sumAccountValue += user.UserAccountValue;
            }
            return sumAccountValue;
        }

        public decimal SumAccountValueFromArray()
        {
            decimal sumAccountValue = 0m;
            foreach (var user in _usersArray)
            {
                sumAccountValue += user.UserAccountValue;
            }
            return sumAccountValue;
        }
    }
}
