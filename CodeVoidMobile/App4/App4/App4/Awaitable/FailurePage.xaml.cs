using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Awaitable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FailurePage : ContentPage
    {
        public FailurePage()
        {
            InitializeComponent();
            string[] ErrorMessages = {"Внимавай повече!",
                "Опитай пак!",
                "Пробвай отново!",
                "Помисли над въпроса отново!",
                "Може би следващият път..."};

            Random randomizedChoice = new Random();
            int value = randomizedChoice.Next(0, ErrorMessages.Length);

            errorsMsg.Text = $"{App.Counter}/3 |" + ErrorMessages[value];
        }
        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}