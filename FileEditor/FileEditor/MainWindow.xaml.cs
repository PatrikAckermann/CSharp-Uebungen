using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using System.Diagnostics;

namespace FileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePath = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void chooseFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result==true)
            {
                filePath = dlg.FileName;
                editorTextBox.IsReadOnly = false;
                filePathLabel.Content = filePath;
                foreach(string line in reader(filePath))
                {
                    editorTextBox.AppendText(line + Environment.NewLine);
                }
            }
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(editorTextBox.Document.ContentStart, editorTextBox.Document.ContentEnd).Text;
            writer(filePath, text);
        }

        static string[] reader(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Trace.WriteLine(line);
            }
            return (lines);
        }

        static void writer(string filePath, string text)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(text);
            }
        }
    }
}
