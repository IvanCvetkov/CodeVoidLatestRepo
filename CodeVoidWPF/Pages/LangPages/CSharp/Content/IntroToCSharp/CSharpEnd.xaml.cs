using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using System.Windows.Media;
using System.Diagnostics;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using System.Text;
using System.Threading.Tasks;
using CodeVoidWPF.Pages.LangPages.CSharp.Content.Alerts;

namespace CodeVoidWPF.Pages.LangPages.CSharp
{
    /// <summary>
    /// Interaction logic for CSharpEnd.xaml
    /// </summary>
    public partial class CSharpEnd : Page
    {
        public CSharpEnd()
        {
            InitializeComponent();
        }
        static List<string> blueTags = new List<string>();
        static List<char> blueSpecials = new List<char>();
        static string text;
        static List<string> grTags = new List<string>();
        static List<char> grspecials = new List<char>();
        static string grtext;
        static readonly List<string> yellowTags = new List<string>();
        static List<char> yellowSpecials = new List<char>();
        static string yellowtext;


        #region ctor
        static CSharpEnd()
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


        private void txtSource_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSource.Document == null)
                return;
            txtSource.TextChanged -= txtSource_TextChanged;

            m_blueTags.Clear();
            gr_Tags.Clear();
            yellow_Tags.Clear();

            Console.WriteLine();
            TextPointer navigator = txtSource.Document.ContentStart;
            TextPointer grnavigator = txtSource.Document.ContentStart;
            TextPointer yellownavigator = txtSource.Document.ContentStart;
            while (navigator.CompareTo(txtSource.Document.ContentEnd) < 0)
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
            while (grnavigator.CompareTo(txtSource.Document.ContentEnd) < 0)
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
            while (yellownavigator.CompareTo(txtSource.Document.ContentEnd) < 0)
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
            txtSource.TextChanged += txtSource_TextChanged;
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

        private void BtnCompile_Click(object sender, RoutedEventArgs e)
        {


            //CSharpCompiler//

            string Framework = 'v' + Environment.Version.ToString();
            string OutputConsoleApp = "Output.exe";
            string StartupPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), OutputConsoleApp);
            txtStatus.Clear();
            CSharpCodeProvider csc = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, OutputConsoleApp, true);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, new TextRange
                (txtSource.Document.ContentStart, txtSource.Document.ContentEnd).Text);
            if (results.Errors.HasErrors)
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => txtStatus.Text += error.ErrorText + "\r\n");
            else
            {
                txtStatus.Text = "========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========";
                Process.Start(StartupPath);
            }


            //VisualBasic Compiler

            //VBCodeProvider vbcsc = new VBCodeProvider();
            //CompilerParameters vbparameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, OutputConsoleApp, true);
            //vbparameters.GenerateExecutable = true;
            //CompilerResults vbresults = vbcsc.CompileAssemblyFromSource(vbparameters, new TextRange
            //    (txtSource.Document.ContentStart, txtSource.Document.ContentEnd).Text);
            //if (vbresults.Errors.HasErrors)
            //    vbresults.Errors.Cast<CompilerError>().ToList().ForEach(error => txtStatus.Text += error.ErrorText + "\r\n");
            //else
            //{
            //    txtStatus.Text = "========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========";
            //    Process.Start(StartupPath);
            //}



            //C++ Compiler
            //var provider = CodeDomProvider.CreateProvider("cpp");
            //CompilerParameters parameters = new CompilerParameters();
            //parameters.ReferencedAssemblies.Add("System.dll");
            //parameters.GenerateExecutable = true;
            //parameters.OutputAssembly = OutputConsoleApp;
            //CompilerResults cppresults = provider.CompileAssemblyFromSource(parameters, new TextRange
            //    (txtSource.Document.ContentStart, txtSource.Document.ContentEnd).Text);

            //CompilerResults result = provider.CompileAssemblyFromFile(parameters, new TextRange
            //        (txtSource.Document.ContentStart, txtSource.Document.ContentEnd).Text);
            //if (cppresults.Errors.HasErrors)
            //    cppresults.Errors.Cast<CompilerError>().ToList().ForEach(error => txtStatus.Text += error.ErrorText + "\r\n");
            //else
            //{
            //    txtStatus.Text = "========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========";
            //    Process.Start(StartupPath);
            //}

        }

        private void CSharpInfo_Click(object sender, RoutedEventArgs e)
        {

            //Points to add
            string[] points = { "15" };

            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/Introduction.txt";
            string finalPath = Path.Combine(docPath, path);

            try
            {
                if (!File.Exists(finalPath))
                {
                    using (var stream = File.Create(finalPath)) { }
                }
                else
                {
                    if (!File.ReadAllText(finalPath).Contains(points[0]))
                    {
                        using (StreamWriter writer = new StreamWriter(finalPath))
                        {
                            writer.WriteLine(points[0]);
                        }
                        Alert alert = new Alert();
                        alert.ShowDialog();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can't write to file" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            //Navigation service
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));


        }
    }
}

