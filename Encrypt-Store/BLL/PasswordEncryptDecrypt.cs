using System;
using System.Collections.Generic;
using System.Text;

using EncryptStore.DAL;

namespace EncryptStore.BLL
{
    public class PasswordEncryptDecrypt
    {
        private DBAccessSingleton dbAccess;

        public PasswordEncryptDecrypt()
        {
            dbAccess = DBAccessSingleton.getInstance;
        }
    }
}
