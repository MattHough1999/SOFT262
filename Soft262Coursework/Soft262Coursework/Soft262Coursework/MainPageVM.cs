using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Soft262Coursework
{
    public class MainPageVM : INotifyPropertyChanged
    {
        //Model
        private ListModel model;
        public ListModel Model
        {
            get => model;
            set
            {
                if (model != value)
                {
                    model = value;
                    OnPropertyChanged();
                }

            }
        }

        //Useful property to reference the navigation page
        protected INavigation Navigation => Application.Current.MainPage.Navigation;

        //Event handling
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand ButtonCommand { get; set; }


        //Bound Data Properties Exposed to the View (read only in this case)
        public string Title => Model.Title;
        public string Description => Model.Description;


        //Create events when properties change
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Main constructor
        public MainPageVM(ListModel m = null)
        {
            //Instantiate the model
            model = m ?? new ListModel("Title 1", "Desc 1");

            //Subscribe to changes in the model
            model.PropertyChanged += OnModelPropertyChanged;

            //The command property - bound to a button in the view
            //ButtonCommand = new Command(execute: NavigateToAboutPage);
        }

        //Watch for events on the model object
        protected void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Flag changes to the view-viewmodel binding layer -  very simple pass-through in this example
            if (e.PropertyName.Equals(nameof(Model.Description)))
            {
                OnPropertyChanged(nameof(Description));
            }
            else if (e.PropertyName.Equals(nameof(Model.Title)))
            {
                OnPropertyChanged(nameof(Title));
            }
        }

        

    }
}
