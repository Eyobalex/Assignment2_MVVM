using System.ComponentModel;
using System.Runtime.CompilerServices;
using Assignment2_MVVM.Annotations;

namespace Assignment2_MVVM.Model
{
    public class Person :INotifyPropertyChanged
    {
        private string fName;
        public string FName
        {
            get { return fName; }
            set { fName = value; } //OnPropertyChanged(FName); }
        }
        private string lName;
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        } //OnPropertyChanged(LName); }}
        private string fullname;

        public string FullName
        {
            get { return FName + " " + LName; }
            set{
                if (fullname != value)
                {
                    fullname = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
            {
                ph(this, new PropertyChangedEventArgs(p));
            }
        }
    }
}