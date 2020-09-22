using CarWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWebApplication.Services
{
    public interface IUserData
    {
        LoginViewModel UserViewModel { get; set; }
        IDataSource DataSource { get; set; }
        bool CheckLoginUser();
    }

    public class UserData : IUserData
    {
        public LoginViewModel UserViewModel { get; set ; }
        public IDataSource DataSource { get; set; }
        
        public bool CheckLoginUser()
        {
            var user = DataSource.GetUserInfo();
            if(user!=null && !string.IsNullOrWhiteSpace(user.Email))
                return true;
            return false;
        }
    }

    public interface IDataSource
    {
        LoginViewModel UserViewModel { get; set; }
        LoginViewModel GetUserInfo();
    }

    public class JsonDataSource : IDataSource
    {
        public LoginViewModel UserViewModel { get; set ; }

        public LoginViewModel GetUserInfo()
        {
            var userVm = new LoginViewModel();
            return userVm;
        }
    }

    public class XmlDataSource : IDataSource
    {
        public LoginViewModel UserViewModel { get; set; }

        public LoginViewModel GetUserInfo()
        {
            var userVm = new LoginViewModel();
            return userVm;
        }
    }
}

