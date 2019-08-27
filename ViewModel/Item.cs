using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VideoEssayBingo.ViewModel
{
    public class Item : ObservableObject
    {
        private string content;
        private bool isChecked;
        private ICommand check;

        public Item(string item, bool check)
        {
            Content = item;
            IsChecked = check;
        }

        public string Content
        {
            get { return content; }
            set { SetProperty(ref content, value); }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set { SetProperty(ref isChecked, value); }
        }

        public ICommand CheckCommand
        {
            get
            {
                check = check ?? new DelegateCommand(CheckButton);
                return check;
            }
        }

        private void CheckButton(object parameter)
        {
            if (IsChecked)
            {
                IsChecked = false;
            }
            else
            {
                IsChecked = true;
            }
        }
    }
}
