using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class AccountManager
    {
        List<Account> accounts;
        public AccountManager()
        {
            accounts = new List<Account>();
        }

        public int CheckRole(int id)
        {
            // Look for account with the given ID
            Account account = accounts.Find(a => a.ID == id);
            if (account != null)
            {
                // Account found, return role as int
                return (int)account.Role;
            }
            // No account found, return -1
            return -1;
        }

        public bool AddAccount(Account account)
        {
            // Look for account with the same ID
            Account exists = accounts.Find(a => a.ID == account.ID);
            if (exists != null)
            {
                // ID already in use, return false
                return false;
            }
            // ID not in use, add account to list and return true
            accounts.Add(account);
            return true;
        }

        public bool RemoveAccount(int id)
        {
            // Look for account with the given ID
            Account account = accounts.Find(a => a.ID == id);
            if (account != null)
            {
                // Account found, remove it, return true
                accounts.Remove(account);
                return true;
            }
            // No account found, return false
            return false;
        }
    }
}
