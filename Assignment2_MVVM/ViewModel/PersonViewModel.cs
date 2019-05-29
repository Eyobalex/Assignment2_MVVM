using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Assignment2_MVVM.Command;
using Assignment2_MVVM.Model;

namespace Assignment2_MVVM.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {

        public PersonViewModel()
        {
            Person = new Person();
            Persons = new ObservableCollection<Person>();
        }

        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; NotifyPropertyChanged("Person"); }
        }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; NotifyPropertyChanged("Persons"); }
        }

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }

                return _SubmitCommand;
            }
        }

        private void SubmitExecute(object parameter)
        {
            Persons.Add(Person);
        }

        private bool CanSubmitExecute(object paramete)
        {
            if (string.IsNullOrEmpty(Person.FName) || string.IsNullOrEmpty(Person.LName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    
}