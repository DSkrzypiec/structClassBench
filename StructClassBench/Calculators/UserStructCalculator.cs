using StructClassBench.Models;
using System.Collections.Generic;
using System.Linq;

namespace StructClassBench.Calculators
{
    public class UserStructCalculator
    {
        private readonly IEnumerable<UserStruct> _users;
        private readonly List<UserStruct> _usersList;
        private readonly UserStruct[] _usersArray;

        public UserStructCalculator(IEnumerable<UserStruct> users)
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
