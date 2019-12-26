using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizesPage : ContentPage
    {
        public QuizesPage()
        {
            InitializeComponent();
        }
        private async void CSharp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CSharpQuizes.CSharpQuiz());
        }

        private async void Python_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PythonQuizes.PythonQuiz());
        }

        private async void CPP_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CPPQuizes.CPPQuiz());
        }

        private async void JS_Clicked(object sender, EventArgs e)
        {
            //await JSGrid.FadeOut(1200, Easing.CubicOut);
            await Navigation.PushAsync(new JSQuizes.JSQuiz());
            //await JSGrid.FadeIn(1200, Easing.CubicIn);
        }
    }
}
