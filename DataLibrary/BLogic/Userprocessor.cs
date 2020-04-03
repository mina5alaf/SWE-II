using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BLogic
{
    public static class Userprocessor
    {
        public static int createuser(string Fullname,String username,String email,string password) {
            UserModel data = new UserModel {
                fullname=Fullname,
                username=username,
                email=email,
                password=password
            };
            string sql = @"insert into dbo.Database1 (Password,Email,Fullname,Username) values (@password,@email,@fullname,@username);";
            return SQLdataaccess.SaveData(sql, data);
        }

        /*public static List<UserModel> LoadUser()
        {
            string sql = @"select Fullname,Username,Email from dbo.Database1;";
            return SQLdataaccess.LoadData<UserModel>(sql);
        }*/
    }
}
