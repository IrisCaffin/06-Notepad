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
using Microsoft.Win32;
using System.IO;

namespace _06_Notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string fileName = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(fileName);
            } 
        }

        private void MenuItem_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                // use File.WriteAllText, pass in ofd.FileName and textBox.Text
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, textBox.Text);
            }

            /*if (result == true)
            {
                string fileName = saveFileDialog.FileName;
                textBox.Text = File.ReadAllText(fileName);*/
        }

        private void MenuItem_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
    }

