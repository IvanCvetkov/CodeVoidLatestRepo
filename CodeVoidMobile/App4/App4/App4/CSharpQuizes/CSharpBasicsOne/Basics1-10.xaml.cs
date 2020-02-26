using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Basics1_10 : ContentPage
    {
        public Basics1_10()
        {
            InitializeComponent();
        }

        public async void Await()
        {
            await Task.Delay(1000);
        }
        private void Forward_Clicked(object sender, EventArgs e)
        {
            if (Answer.Text == "15")
            {
                DisplayAlert("Поздравления!", "Верен Отговор", "OK");
                Await();
                Navigation.PushAsync(new Basics2_10());
            }
            else
                DisplayAlert("Грешен отговор!", "Опитай пак", "OK");
        }
    }
}