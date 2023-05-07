using BInding.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BInding.ViewModel
{
    public class CustomerViewModel : ObservasionObject
    {
        private Customer _customer ;

        public Customer Customer {
            get => _customer;
            set { 
                _customer = value;
                OnPropertyChanged();
            }
        }

        public void LoadOrderAction(object ?param) {
            Customer.LoadCustomer();
        }

        public ICommand LoadOrder;

        public CustomerViewModel()
        {
            LoadOrder = new RelayCommand(LoadOrderAction);
            Customer = new Customer();
        }
    }
}
