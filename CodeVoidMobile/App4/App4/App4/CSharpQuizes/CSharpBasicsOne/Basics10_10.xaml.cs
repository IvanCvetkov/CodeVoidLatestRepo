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
    public partial class Basics10_10 : ContentPage
    {
        public Basics10_10()
        {
            InitializeComponent();
        }
        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option4.IsChecked == true && option3.IsChecked == false
                     && option2.IsChecked == false && option1.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new TenthToFinalRight());
            }
            else
            {
                await Navigation.PushAsync(new TenthToFinalWrong());
                await Task.Delay(300);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new Basics8_10());
            return true;
        }
    }
}