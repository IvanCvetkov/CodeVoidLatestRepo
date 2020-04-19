using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Final : ContentPage
    {
        public Final()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Navigation.PushAsync(new CSharpQuiz());
        }
    }
}