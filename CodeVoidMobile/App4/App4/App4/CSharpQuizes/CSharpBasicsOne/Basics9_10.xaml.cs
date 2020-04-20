using App4.CSharpQuizes.AwaitRightPages;
using App4.CSharpQuizes.AwaitWrongPages;
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
    public partial class Basics9_10 : ContentPage
    {
        public Basics9_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option2.IsChecked == true && option3.IsChecked == false
                     && option4.IsChecked == false && option1.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new NinethToTenthRight());
            }
            else
            {
                await Navigation.PushAsync(new NinethToTenthWrong());
                await Task.Delay(300);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}