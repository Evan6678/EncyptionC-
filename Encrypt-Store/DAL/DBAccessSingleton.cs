using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using LiteDB;

namespace EncryptStore.DAL
{
    public sealed class DBAccessSingleton
    {

        /// <summary>
        /// Singleton instance
        /// </summary>
        private static DBAccessSingleton instance = null;

        /// <summary>
        /// database instance
        /// </summary>
        private ILiteDatabase database; 

        /// <summary>
        /// constructor to get or create database
        /// </summary>
        DBAccessSingleton() 
        {
            try
            {
                database = new LiteDatabase(@"C:\PasswordData\passwords.db");
            }
            catch(DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"C:\PasswordData");
                database = new LiteDatabase(@"C:\PasswordData\passwords.db");
            }

            
        }

        /// <summary>
        /// Accessor to get singleton instance
        /// </summary>
        public static DBAccessSingleton getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBAccessSingleton();
                }
                return instance;
            }
        }

        private void CreateNewDBStructure()
        {
            database.GetCollection<>
        }
    }
}
