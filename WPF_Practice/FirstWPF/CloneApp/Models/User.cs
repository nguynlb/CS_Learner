using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneApp.Models
{
    public class User
    {
		private static int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}


		private string _username;

		public string Username
		{
			get { return _username; }
			set { _username = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public User()
		{
			Username = string.Empty;
			Password = string.Empty;
            Id = _id + 1;
		}
    }
}
