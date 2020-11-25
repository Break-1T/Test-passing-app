using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Test_creating_app.Dialog_Boxes
{
    /// <summary>
    /// Логика взаимодействия для CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private MainWindow main;

        private void CreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            main.Path = FilePath.Text + FileName.Text + ".json";
            Close();
        }
    }
}
