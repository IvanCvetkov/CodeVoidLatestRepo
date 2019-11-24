using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Variable
{

    /// <summary>
    /// Interaction logic for VarNext.xaml
    /// </summary>
    public partial class VarNext : Page
    {
        public VarNext()
        {
            InitializeComponent();
        }
        private void Nextvarpage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Variable/Exercises.xaml", UriKind.RelativeOrAbsolute));
        }
        private void BackToVariables_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Variable/Variables.xaml", UriKind.Relative));
        }


        static List<string> blueTags = new List<string>();
        static List<char> blueSpecials = new List<char>();
        static string text;
        static List<string> grTags = new List<string>();
        static List<char> grspecials = new List<char>();
        static string grtext;
        static List<string> yellowTags = new List<string>();
        static List<char> yellowSpecials = new List<char>();
        static string yellowtext;


        #region ctor
        static VarNext()
        {
            string[] blueWords = { "string", "char", "null", "namespace", "class", "using", "public", "static", "void", "int" };
            string[] greenWords = { "Console" };
            string[] yellowWords = { "ReadKey", "WriteLine", "Write" };
            blueTags = new List<string>(blueWords);
            grTags = new List<string>(greenWords);
            yellowTags = new List<string>(yellowWords);
            char[] chrs = {
            '.',
            ')',
            '(',
            '[',
            ']',
            '>',
            '<',
            ':',
            ';',
            '\n',
            '\t',
            '\r'
        };
            blueSpecials = new List<char>(chrs);
            grspecials = new List<char>(chrs);
            yellowSpecials = new List<char>(chrs);
        }
        #endregion
        public static bool IsKnownTag(string tag)
        {
            return blueTags.Exists(delegate (string s) { return s.ToLower().Equals(tag.ToLower()); });
        }
        private static bool GetSpecials(char i)
        {
            foreach (var item in blueSpecials)
            {
                if (item.Equals(i))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool grIsKnownTag(string tag)
        {
            return grTags.Exists(delegate (string s) { return s.ToLower().Equals(tag.ToLower()); });
        }
        private static bool grGetSpecials(char i)
        {
            foreach (var item in grspecials)
            {
                if (item.Equals(i))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool yellowIsKnownTag(string tag)
        {
            return yellowTags.Exists(delegate (string s) { return s.ToLower().Equals(tag.ToLower()); });
        }
        private static bool yellowGetSpecials(char i)
        {
            foreach (var item in yellowSpecials)
            {
                if (item.Equals(i))
                {
                    return true;
                }
            }
            return false;
        }

        //tags are used to indicate the beginning and the end of the keyword (place to color)
        new struct Tag
        {
            public TextPointer StartPosition;
            public TextPointer EndPosition;
            public string Word;
        }
        struct GrTag
        {
            public TextPointer grStartPosition;
            public TextPointer grEndPosition;
            public string grWord;
        }
        struct YellowTag
        {
            public TextPointer yellowStartPosition;
            public TextPointer yellowEndPosition;
            public string yellowWord;
        }


        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtStatus.Document == null)
                return;
            txtStatus.TextChanged -= txtStatus_TextChanged;

            m_blueTags.Clear();
            gr_Tags.Clear();
            yellow_Tags.Clear();

            Console.WriteLine();
            TextPointer navigator = txtStatus.Document.ContentStart;
            TextPointer grnavigator = txtStatus.Document.ContentStart;
            TextPointer yellownavigator = txtStatus.Document.ContentStart;
            while (navigator.CompareTo(txtStatus.Document.ContentEnd) < 0)
            {
                TextPointerContext context = navigator.GetPointerContext(LogicalDirection.Backward);
                if (context == TextPointerContext.ElementStart && navigator.Parent is Run)
                {
                    text = ((Run)navigator.Parent).Text; //fix 2
                    if (text != "")
                        CheckWordsInRun((Run)navigator.Parent);
                }
                navigator = navigator.GetNextContextPosition(LogicalDirection.Forward);
            }
            while (grnavigator.CompareTo(txtStatus.Document.ContentEnd) < 0)
            {
                TextPointerContext grcontext = grnavigator.GetPointerContext(LogicalDirection.Backward);
                if (grcontext == TextPointerContext.ElementStart && grnavigator.Parent is Run)
                {
                    grtext = ((Run)grnavigator.Parent).Text; //fix 2
                    if (grtext != "")
                        grCheckWordsInRun((Run)grnavigator.Parent);
                }
                grnavigator = grnavigator.GetNextContextPosition(LogicalDirection.Forward);
            }
            while (yellownavigator.CompareTo(txtStatus.Document.ContentEnd) < 0)
            {
                TextPointerContext yellowcontext = yellownavigator.GetPointerContext(LogicalDirection.Backward);
                if (yellowcontext == TextPointerContext.ElementStart && yellownavigator.Parent is Run)
                {
                    yellowtext = ((Run)yellownavigator.Parent).Text; //fix 2
                    if (yellowtext != "")
                        yellowCheckWordsInRun((Run)yellownavigator.Parent);
                }
                yellownavigator = yellownavigator.GetNextContextPosition(LogicalDirection.Forward);
            }
            for (int i = 0; i < m_blueTags.Count; i++)
            {
                try
                {
                    TextRange range = new TextRange(m_blueTags[i].StartPosition, m_blueTags[i].EndPosition);
                    range.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Blue));
                    range.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                }
                catch { }
            }
            for (int i = 0; i < gr_Tags.Count; i++)
            {
                try
                {
                    Console.WriteLine();
                    TextRange grrange = new TextRange(gr_Tags[i].grStartPosition, gr_Tags[i].grEndPosition);
                    grrange.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Green));
                    grrange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                }
                catch { }
            }
            for (int i = 0; i < yellow_Tags.Count; i++)
            {
                try
                {
                    Console.WriteLine();
                    TextRange yellowrange = new TextRange(yellow_Tags[i].yellowStartPosition, yellow_Tags[i].yellowEndPosition);
                    yellowrange.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.GreenYellow));
                    yellowrange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                }
                catch { }
            }
            txtStatus.TextChanged += txtStatus_TextChanged;
        }
        List<Tag> m_blueTags = new List<Tag>();
        List<GrTag> gr_Tags = new List<GrTag>();
        List<YellowTag> yellow_Tags = new List<YellowTag>();
        internal void CheckWordsInRun(Run theRun)
        {
            int sIndex = 0;
            int eIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsWhiteSpace(text[i]) | GetSpecials(text[i]))
                {
                    if (i > 0 && !(Char.IsWhiteSpace(text[i - 1]) | GetSpecials(text[i - 1])))
                    {
                        eIndex = i - 1;
                        string word = text.Substring(sIndex, eIndex - sIndex + 1);
                        if (IsKnownTag(word))
                        {
                            Tag t = new Tag();
                            t.StartPosition = theRun.ContentStart.GetPositionAtOffset(sIndex, LogicalDirection.Forward);
                            t.EndPosition = theRun.ContentStart.GetPositionAtOffset(eIndex + 1, LogicalDirection.Backward);
                            t.Word = word;
                            m_blueTags.Add(t);
                        }
                    }
                    sIndex = i + 1;
                }
            }
            //last word case fix
            string lastWord = text.Substring(sIndex, text.Length - sIndex);
            if (IsKnownTag(lastWord))
            {
                Tag t = new Tag();
                t.StartPosition = theRun.ContentStart.GetPositionAtOffset(sIndex, LogicalDirection.Forward);
                t.EndPosition = theRun.ContentStart.GetPositionAtOffset(text.Length, LogicalDirection.Backward); //fix 1
                t.Word = lastWord;
                m_blueTags.Add(t);
            }
        }
        internal void grCheckWordsInRun(Run grtheRun)
        {
            int grsIndex = 0;
            int greIndex = 0;

            for (int i = 0; i < grtext.Length; i++)
            {
                if (Char.IsWhiteSpace(grtext[i]) | grGetSpecials(grtext[i]))
                {
                    if (i > 0 && !(Char.IsWhiteSpace(grtext[i - 1]) | grGetSpecials(grtext[i - 1])))
                    {
                        greIndex = i - 1;
                        string grword = grtext.Substring(grsIndex, greIndex - grsIndex + 1);
                        if (grIsKnownTag(grword))
                        {
                            GrTag grt = new GrTag();
                            grt.grStartPosition = grtheRun.ContentStart.GetPositionAtOffset(grsIndex, LogicalDirection.Forward);
                            grt.grEndPosition = grtheRun.ContentStart.GetPositionAtOffset(greIndex + 1, LogicalDirection.Backward);
                            grt.grWord = grword;
                            gr_Tags.Add(grt);
                        }
                    }
                    grsIndex = i + 1;
                }
            }
            //last word case fix
            string grlastword = grtext.Substring(grsIndex, grtext.Length - grsIndex);
            if (grIsKnownTag(grlastword))
            {
                GrTag grt = new GrTag();
                grt.grStartPosition = grtheRun.ContentStart.GetPositionAtOffset(grsIndex, LogicalDirection.Forward);
                grt.grEndPosition = grtheRun.ContentStart.GetPositionAtOffset(grtext.Length, LogicalDirection.Backward); //fix 1
                grt.grWord = grlastword;
                gr_Tags.Add(grt);
            }
        }
        internal void yellowCheckWordsInRun(Run yellowtheRun)
        {
            int yellowsIndex = 0;
            int yelloweIndex = 0;
            
            for (int i = 0; i < yellowtext.Length; i++)
            {
                if (Char.IsWhiteSpace(yellowtext[i]) | yellowGetSpecials(yellowtext[i]))
                {
                    if (i > 0 && !(Char.IsWhiteSpace(yellowtext[i - 1]) | yellowGetSpecials(yellowtext[i - 1])))
                    {
                        yelloweIndex = i - 1;
                        string yelloword = yellowtext.Substring(yellowsIndex, yelloweIndex - yellowsIndex + 1);
                        if (yellowIsKnownTag(yelloword))
                        {
                            YellowTag yellowt = new YellowTag();
                            yellowt.yellowStartPosition = yellowtheRun.ContentStart.GetPositionAtOffset(yellowsIndex, LogicalDirection.Forward);
                            yellowt.yellowEndPosition = yellowtheRun.ContentStart.GetPositionAtOffset(yelloweIndex + 1, LogicalDirection.Backward);
                            yellowt.yellowWord = yelloword;
                            yellow_Tags.Add(yellowt);
                        }
                    }
                    yellowsIndex = i + 1;
                }
            }
            //last word case fix
            string yellowlastWord = yellowtext.Substring(yellowsIndex, yellowtext.Length - yellowsIndex);
            if (yellowIsKnownTag(yellowlastWord))
            {
                YellowTag yellowt = new YellowTag();
                yellowt.yellowStartPosition = yellowtheRun.ContentStart.GetPositionAtOffset(yellowsIndex, LogicalDirection.Forward);
                yellowt.yellowEndPosition = yellowtheRun.ContentStart.GetPositionAtOffset(yellowtext.Length, LogicalDirection.Backward); //fix 1
                yellowt.yellowWord = yellowlastWord;
                yellow_Tags.Add(yellowt);
            }
        }
    }
}
