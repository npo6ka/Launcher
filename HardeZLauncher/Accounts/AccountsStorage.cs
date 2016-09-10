using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class AccountsStorage
    {
        private List<Account> accountList;
        private int selectedAccount;

        public AccountsStorage()
        {
            accountList = new List<Account>();
            selectedAccount = -1;
        }

        ~AccountsStorage()
        {
            accountList.Clear();
        }

        private int findAccoutInList(Account acnt)
        {
            int size = countAccounts();
            for (int i = 0; i < size; ++i)
            {
                if (acnt.equals(accountList[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int SelectedAccount
        {
            get
            {
                return selectedAccount;
            }

            private set
            {
                selectedAccount = value;
            }
        }

        public bool chengeSelectedAccount(int numAccount)
        {
            if (accountList.Count < numAccount - 1 || numAccount < -1)
            {
                SelectedAccount = -1;
                return false;
            } else
            {
                SelectedAccount = numAccount;
                return true;
            }
        }

        public bool chengeSelectedAccount(Account acnt)
        {
            return chengeSelectedAccount(findAccoutInList(acnt));
        }

        public int addAccount(Account acnt)
        {
            int err = acnt.isValid();
            if (acnt != null || err == 1)
            {
                accountList.Add(acnt);
                return 1;
            } else
            {
                return err;
            }
        }

        public void removeAccount(Account acnt)
        {
            accountList.RemoveAt(findAccoutInList(acnt));
        }

        public Account getAccount(int numAccount)
        {
            if (accountList.Count < numAccount - 1 || numAccount < -1)
            {
                return null;
            }
            else
            {
                return accountList[numAccount];
            }
        }

        public Account getSelectedAccounts()
        {
            return getAccount(SelectedAccount);
        }

        public int countAccounts()
        {
            return accountList.Count;
        }
    }
}
