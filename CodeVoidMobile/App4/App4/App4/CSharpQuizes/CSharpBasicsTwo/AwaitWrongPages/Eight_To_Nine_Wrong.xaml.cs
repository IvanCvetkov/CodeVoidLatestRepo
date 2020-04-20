using App4.CSharpQuizes.CSharpBasicsTwo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.CSharpQuizes.CSharpBasicsTwo.AwaitWrongPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eight_To_Nine_Wrong : ContentPage
    {
        public Eight_To_Nine_Wrong()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(2000);
            await Navigation.PushAsync(new Basics9_20());
        }
    }
}