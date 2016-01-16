using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.User
{
    /// <summary>
    /// 用户
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 账号id
        /// </summary>
        private string _accountid;

        public string AccountId
        {
            get
            {
                return _accountid;
            }

            set
            {
                _accountid = value;
            }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        private string _username;
        public string UserName
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        /// <summary>
        /// 密码
        /// </summary>
        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        /// <summary>
        /// 电话
        /// </summary>
        private string _telephone;
        public string TelePhone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
            }
        }

        /// <summary>
        /// 手机
        /// </summary>
        private string mobilephone;
        public string MobilePhone
        {
            get
            {
                return mobilephone;
            }

            set
            {
                mobilephone = value;
            }
        }

    }
}
