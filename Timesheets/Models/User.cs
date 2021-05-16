using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class User
    {
        /// <summary> Информация о пользователе системы </summary>
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}
