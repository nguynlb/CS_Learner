using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command1.Models
{
    public class ViewModel 
    {
        private bool _isCheck;
        public bool IsCheck
        {
            get { return _isCheck; }
            set { 
                _isCheck = value;
            }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
            }
        }
    }
}
