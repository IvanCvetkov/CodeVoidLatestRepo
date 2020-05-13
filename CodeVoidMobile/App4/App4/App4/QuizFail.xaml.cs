using System;
using App4.CSharpQuizes;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizFail : ContentPage
    {
        public QuizFail()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            App.Counter = 0;
            await Task.Delay(2500);
            await Navigation.PushAsync(new CSharpQuiz());
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new CSharpQuiz());
            return false;
        }
    }
}