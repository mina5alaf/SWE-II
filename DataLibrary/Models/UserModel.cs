using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    class UserModel
    {
        public int id { set; get; }
        public string password { set; get; }
        public string username { set; get; }
        public string fullname { set; get; }
        public string email { set; get; }
    }
}
