using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content
{
    /// <summary>
    /// Interaction logic for Variables.xaml
    /// </summary>
    public partial class Variables : Page
    {
        public Variables()
        {
            InitializeComponent();
        }

        

        private void BackToInfo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));
        }

        private void Nextvar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Variable/VarNext.xaml", UriKind.Relative));

        }

        static List<string> tags = new List<string>();
        static List<char> specials = new List<char>();
        static string text;
        #region ctor
        static Variables()
        {
            string[] specialWords = { "string", "namespace", "class", "using", "true", "public",
                "static", "void", "int", "short", "float", "double", "bool" };
            tags = new List<string>(specialWords);
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
            specials = new List<char>(chrs);
        }
        #endregion
        public static bool IsKnownTag(string tag)
        {
            return tags.Exists(delegate (string s) { return s.ToLower().Equals(tag.ToLower()); });
        }
        private static bool GetSpecials(char i)
        {
            foreach (var item in specials)
            {
                if (item.Equals(i))
                {
                    return true;
                }
            }
            return false;
        }

        new struct Tag
        {
            public TextPointer StartPosition;
            public TextPointer EndPosition;
            public string Word;
        }



        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtStatus.Document == null)
                return;
            txtStatus.TextChanged -= txtStatus_TextChanged;

            m_tags.Clear();

            TextPointer navigator = txtStatus.Document.ContentStart;
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

            for (int i = 0; i < m_tags.Count; i++)
            {
                try
                {
                    TextRange range = new TextRange(m_tags[i].StartPosition, m_tags[i].EndPosition);
                    range.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Blue));
                    range.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                }
                catch { }
            }
            txtStatus.TextChanged += txtStatus_TextChanged;
        }
        List<Tag> m_tags = new List<Tag>();
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
                            m_tags.Add(t);
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
                m_tags.Add(t);
            }
        }
    }
}
