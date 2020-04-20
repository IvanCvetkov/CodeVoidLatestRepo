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
    public partial class Basics8_10 : ContentPage
    {
        public Basics8_10()
        {
            InitializeComponent();
        }

        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if(Answer.Text == "153")
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new EightToNinthRight());
            }
            else
            {
                await Navigation.PushAsync(new EightToNinthWrong());
                await Task.Delay(300);
            }
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}