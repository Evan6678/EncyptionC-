using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypt_Store.Types
{
    class DatabaseCollection
    {
        UserCollection user = 

    }

    class UserCollection
    {
        /// <summary>
        /// Main User UUID
        /// </summary>
        public Guid UID = Guid.NewGuid();
        /// <summary>
        /// Main User name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date new user was created
        /// </summary>
        public DateTime CreationDate = DateTime.Now;
    }
}
