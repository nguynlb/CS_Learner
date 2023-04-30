using Command.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Command.ViewModel
{
    public class MessageViewModel
    {
        public string MessageText { get; set; }
        public ICommand ShowMessageCommand { get; private set; }

        public void Display()
        {
            MessageBox.Show(MessageText);
        }

        public MessageViewModel()
        {
            ShowMessageCommand = new MessageCommand(Display);
        }
    }
}
