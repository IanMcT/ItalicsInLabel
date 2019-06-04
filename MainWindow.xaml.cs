using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace euler13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //simulating here

            string parsedXmlText1 = "Test";

            string parsedXmlText2 = "ing";

            string parsedXmlText3 = "underline";
            string andItalics = " and italicize this";
            string finishitoff = "This should be normal";

            TextBlock tb = new TextBlock();

            tb.Inlines.Add(new Bold(new Run(parsedXmlText1)));

            tb.Inlines.Add(new Run(parsedXmlText2));

            tb.Inlines.Add(new Run("  "));

            tb.Inlines.Add(new Underline(new Run(parsedXmlText3)));
            tb.Inlines.Add(new Italic(new Run(andItalics)));
            tb.Inlines.Add(new Run(finishitoff));

            lbl.Content = tb;
        }

        private void tbTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            string parsedXmlText1 = "Test";

            string parsedXmlText2 = "ing";

            string parsedXmlText3 = "underline";
            string andItalics = " and italicize this";
            andItalics = tbTitle.Text;
            string finishitoff = "This should be normal";

            TextBlock tb = new TextBlock();

            tb.Inlines.Add(new Bold(new Run(parsedXmlText1)));

            tb.Inlines.Add(new Run(parsedXmlText2));

            tb.Inlines.Add(new Run("  "));

            tb.Inlines.Add(new Underline(new Run(parsedXmlText3)));
            tb.Inlines.Add(new Italic(new Run(andItalics)));
            tb.Inlines.Add(new Run(finishitoff));

            lbl.Content = tb;
        }
    }
}
