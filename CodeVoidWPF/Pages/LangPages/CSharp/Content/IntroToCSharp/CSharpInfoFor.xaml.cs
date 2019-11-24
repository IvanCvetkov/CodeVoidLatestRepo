//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Media.Animation;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.IntroToCSharp
//{
//    /// <summary>
//    /// Interaction logic for CSharpInfoFor.xaml
//    /// </summary>
//    public partial class CSharpInfoFor : Page
//    {
//        public CSharpInfoFor()
//        {
//            InitializeComponent();
//        }

//        private void Page_Loaded(object sender, RoutedEventArgs e)
//        {

//        }
//        public void AllRectanglesLoaded()
//        {
//            //animation code
//            DoubleAnimation arraysRectangle = new DoubleAnimation()
//            {
//                From = 0,
//                To = 920,
//                Duration = TimeSpan.FromSeconds(1),

//                EasingFunction = new QuinticEase()
//            };
//            DoubleAnimation exceptionsRectangle = new DoubleAnimation()
//            {
//                From = 0,
//                To = 920,
//                Duration = TimeSpan.FromSeconds(1),

//                EasingFunction = new QuinticEase()
//            };
//            DoubleAnimation methodsRectangle = new DoubleAnimation()
//            {
//                From = 0,
//                To = 920,
//                Duration = TimeSpan.FromSeconds(1),

//                EasingFunction = new QuinticEase()
//            };
//            DoubleAnimation textFilesRectangle = new DoubleAnimation()
//            {
//                From = 0,
//                To = 920,
//                Duration = TimeSpan.FromSeconds(1),

//                EasingFunction = new QuinticEase()
//            };




//            //calling the animation code

//            //reffering to the XAML objects
//            ArraysRec.BeginAnimation(WidthProperty, arraysRectangle);
//            ExceptionsRec.BeginAnimation(WidthProperty, exceptionsRectangle);
//            MethodsRec.BeginAnimation(WidthProperty, methodsRectangle);
//            TextFilesRec.BeginAnimation(WidthProperty, textFilesRectangle);
//        }
//    }
//}
