using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodOrder_Xamarin.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
            new Pick { Title = "Breakfast Sub", Image ="sub.png", Description = "Order a healthy breakfast sub"},
            new Pick { Title = "Fast Chinese", Image = "box.png", Description = "Order a noodle-chicken box on the go"},
            new Pick { Title = "Big-Turk", Image = "turk.png", Description = "When you need a whole turkey ASAP"}
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

