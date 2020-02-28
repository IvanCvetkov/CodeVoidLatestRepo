using App4.CSharpQuizes.AwaitRightPages;
using App4.CSharpQuizes.AwaitWrongPages;
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

        //public async void Await()
        //{
        //    await Task.Delay(1000);
        //}
        private async void Forward_Clicked(object sender, EventArgs e)
        {
            if (Answer.Text == "15")
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new AwaitRight());
            }
            else
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new AwaitWrong());
            }
        }
    }
}