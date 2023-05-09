using CloneApp.Core;
using CloneApp.Models;
using System.Windows.Input;

namespace CloneApp.ViewModels
{
    public class MainViewModel : ObservationObject
    {
        private string _title;
        private string _icon;

        private User _user = new User();

        public User _User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnProrpertyChanged(nameof(_User));
            }
        }


        public string Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                OnProrpertyChanged(nameof(Icon));
            }
        }



        public string Title
        {
            get => _title; set
            {
                _title = value;
                OnProrpertyChanged(nameof(Title));
            }
        }


        //Command
        public ICommand ShowHomeView { get; set; }
        public ICommand ShowDashboardView { get; set; }
        public ICommand ShowAPIView { get; set; }
        public ICommand ShowStoryView { get; set; }


        // CommandLogin
        public ICommand LoginCommand { get; private set; }

        public MainViewModel()
        {
            Title = "Home";
            Icon = "Home";

            ShowHomeView = new RelayCommand(o =>
            {
                Title = "Home";
                Icon = "Home";
            });
            ShowDashboardView = new RelayCommand(o =>
            {
                Title = "Dashboard";
                Icon = "Chartline";

            });
            ShowStoryView = new RelayCommand(o =>
            {
                Title = "Story";
                Icon = "Pen";


            });
            ShowAPIView = new RelayCommand(o =>
            {
                Title = "API";
                Icon = "Book";
            });


            LoginCommand = new RelayCommand(LoginAction, CanLoginAction);
        }

        private void LoginAction(object obj)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private bool CanLoginAction(object obj)
        {
            return _User.Username.Length > 6 && _User.Password.Length > 6;
        }
    }
}
