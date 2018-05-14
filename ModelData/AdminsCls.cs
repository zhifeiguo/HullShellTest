using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData
{
    public class AdminsCls
    {
        private int _Id;
        [Description("序号")]
        [DisplayName("序号")]
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        private string _UserName;
        [Description("用户名")]
        [DisplayName("用户名")]
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        private string _PassWord;
        [Description("密码")]
        [DisplayName("密码")]
        public string PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                _PassWord = value;
            }
        }

        private string _Role;
        [Description("角色")]
        [DisplayName("角色")]
        public string Role
        {
            get
            {
                return _Role;
            }
            set
            {
                _Role = value;
            }
        }
    }
}
