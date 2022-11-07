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

namespace wpf_einführung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string chars = "abcdefghijklmnopqrstuvwxyz1234567890"; // List of characters that the random string button can use.
        string hexChars = "0123456789abcdef";
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // "Wechsel Text" Button Click
        {
            
            Label1.Content = getRandomString(); // Set label to show string
            Label2.Content = getRandomString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // "Wechsel Farbe Label und Buttons" Button Click
        {
            changeTextBtn.Background = getRandomColor(); // Changes button BG to hex code
            changeColorBtn.Background = getRandomColor();
            createOtherSideBtn.Background = getRandomColor();
            Label1.Background = getRandomColor();
            changeTextBtn2.Background = getRandomColor(); // Changes button BG to hex code
            changeColorBtn2.Background = getRandomColor();
            Label2.Background = getRandomColor();
        }

        public Brush getRandomColor()
        {
            var converter = new System.Windows.Media.BrushConverter(); // Converter that can convert Hex codes to Brush Color
            string hexCode = "#";
            for (int i = 0; i < 6; i++) // Loops 6 times to generate 6 chars for hex code
            {
                hexCode += hexChars[random.Next(hexChars.Length)]; // Chooses random char and adds to code
            }
            return (Brush)converter.ConvertFromString(hexCode);
        }

        public string getRandomString()
        {
            string randomStr = ""; //Empty string
            for (int i = 0; i <= random.Next(2, 21); i++) //Repeat for a random amount in range 2 to 20.
            {
                randomStr += chars[random.Next(chars.Length)]; // Add a random character from a list to the string. 
            }
            return randomStr;
        }

        private void createOtherSideBtn_Click(object sender, RoutedEventArgs e) // Reveals the elements on the right side of the window
        {
            Label2.Visibility = Visibility.Visible;
            changeTextBtn2.Visibility = Visibility.Visible;
            changeColorBtn2.Visibility = Visibility.Visible;
            createOtherSideBtn2.Visibility = Visibility.Visible;
        }
    }
}
