﻿using StructClassBench.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace StructClassBench.Calculators
{
    public class UserClassCalculator
    {
        private readonly IEnumerable<UserClass> _users;
        private readonly List<UserClass> _usersList;
        private readonly UserClass[] _usersArray;

        public UserClassCalculator(IEnumerable<UserClass> users)
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

        public void ModifyEachElementFromList()
        {
            for (var i = 0; i < _usersList.Count; i++)
            {
                var tmp = _usersList[i];
                tmp.UserAge += 2;
                _usersList[i] = tmp;
            }
        }

        public void ModifyEachElementFromArray()
        {
            for (var i = 0; i < _usersArray.Length; i++)
            {
                _usersArray[i].UserAge += 2;
            }
        }
    }
}
