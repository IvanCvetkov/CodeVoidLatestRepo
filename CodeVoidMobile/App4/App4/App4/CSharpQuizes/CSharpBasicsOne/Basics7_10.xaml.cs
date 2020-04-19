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
    public partial class Basics7_10 : ContentPage
    {
        public Basics7_10()
        {
            InitializeComponent();
        }
        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (option1.IsChecked == true && option3.IsChecked == false
                  && option4.IsChecked == false && option2.IsChecked == false)
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new SeventhToEighthRight());
            }
            else
            {
                await Navigation.PushAsync(new SeventhToEighthWrong());
                await Task.Delay(300);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new Basics6_10());
            return true;
        }
    }
}