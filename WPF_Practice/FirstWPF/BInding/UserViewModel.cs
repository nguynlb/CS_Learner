using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BInding
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _userName = string.Empty;
        private string _password = string.Empty;
        private string _email = string.Empty;

        public string Username { 
            get {  return _userName; }
            set { _userName = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Email {
            get { return _email; }
            set { _email = value; 
                OnPropertyChanged(nameof(Email));

            }
        }
        public string Password {
            get { return _password; }
            set { _password = value; 
                OnPropertyChanged(nameof(Password));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
