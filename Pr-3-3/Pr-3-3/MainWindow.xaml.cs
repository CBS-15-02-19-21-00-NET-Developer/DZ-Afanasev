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
using System.IO.Compression;

namespace Pr_3_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FilePath { get; set; }
        public string TextFile { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            listBox.Items.Clear();

            string[] allFoundFiles = Directory.GetFiles(FilePath, "*"+TextFile+"*", SearchOption.AllDirectories);
            foreach (string file in allFoundFiles)
            {
                listBox.Items.Add(file);
            }
            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilePath = dir.Text;
        }

        private void TextBox_nameF_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextFile = nameF.Text;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (listBox.SelectedItem != null)
            {
                var li = (string)listBox.Items[listBox.SelectedIndex];//выбранный элемент листбокса

                StreamReader stream1 = File.OpenText(li);
                string text;
                view.Clear();
                while ((text = stream1.ReadLine()) != null)                    
                view.Text += text;

                stream1.Close();//закрываем поток
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Создание файла и архива.
            var li = (string)listBox.Items[listBox.SelectedIndex];//выбранный элемент листбокса
            FileStream source = File.OpenRead(li);
            FileStream destination = File.Create(li+".zip");

            // Создание компрессора.
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            // Заполнение архива информацией из файла.
            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }

            // Удаление компрессора.
            compressor.Close();

            MessageBox.Show("Файл заархивирован. Нажмите поиск, чтобы его найти");
        }
    }
}
