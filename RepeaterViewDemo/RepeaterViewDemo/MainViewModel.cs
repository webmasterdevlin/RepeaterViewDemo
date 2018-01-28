using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace RepeaterViewDemo
{
    public class MainViewModel : BaseViewModel
    {
        private List<string> _employees;
        private List<string> _students;
        public List<string> Employees
        {
            get => _employees;
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }
        public List<string> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged();
            }
        }
        public ICommand SelectStudentCommand => new Command(student => {});
        public MainViewModel()
        {
            Employees = new List<string>
            {
                "Kakashi", "Guy", "Iruka", "Asuma", "Yamato", "Minato", "Jiraiya", "Danzo", "Killer Bee", "Sarutobi", "Obito", "Orochimaru"
            };

            Students = new List<string>
            {
                "Naruto", "Choji", "Lee", "Sai", "Shino", "Ten ten", "Ino", "Sakura", "Hinata", "Neiji", "Sasuke", "Kiba", "Konohamaru"
            };
        }
    }
}
