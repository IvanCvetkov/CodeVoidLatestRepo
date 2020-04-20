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
    public partial class Basics3_10 : ContentPage
    {
        public Basics3_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (Answer.Text == "55")
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new ThirdToForthRight());
            }
            else
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new ThirdToForthWrong());
            }
        }
        
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}