using SampleLoginApp.Command;
using SampleLoginApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SampleLoginApp.ViewModels
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChange(string propertyName) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }

    internal class UserViewModel : ViewModelBase
    {
        // Dependency Injection
        private User User;
        public ICommand loginCommand { get; }

        public UserViewModel()
        {
            this.User = new User();
            loginCommand = new LoginCommand(Username => LoggedIn(Username));
        }

        private void LoggedIn(object param)
        {
            MessageBox.Show($"Login Successfull as {param}");
        }

        public string Username 
        {   get => User.Username;
            set {
                User.Username = value;
                OnPropertyChange(nameof(Username));
            }
        }

        public string Password
        {   get => User.Password;
            set
            {
                User.Password = value;
                OnPropertyChange(nameof(Password));
            }
        }
    }
}
