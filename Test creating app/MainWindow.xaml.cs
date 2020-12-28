using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Test_creating_app.Models;
using Test_creating_app.Services;
using Microsoft.Win32;

namespace Test_creating_app
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

        public string Path { get; set; }


        public FileIOService IOService { get; set; }
        private BindingList<QuestionPattern> _allQuestions;

        private void CreateItem_OnClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выбор пути к файлу";
            fileDialog.Filter = "Test files (*.json)|*.json";
            fileDialog.ShowDialog();
            Path = fileDialog.FileName;
            IOService = new FileIOService(Path);
            
            _allQuestions = new BindingList<QuestionPattern>();
            _allQuestions.Add(new QuestionPattern("Введите вопрос", "Введите вариант ответа", "Введите вариант ответа"));
            
            QuestionsList.ItemsSource = _allQuestions;

        }

        private void SaveItem_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                IOService.SaveData(_allQuestions);
                MessageBox.Show("Файл успешно сохранён");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении файла");
            }
        }

        private void LoadItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Test files (*.json)|*.json|All files (*.*)|*.*";
                fileDialog.ShowDialog();
                Path = fileDialog.FileName;
                IOService = new FileIOService(Path);
                _allQuestions = IOService.LoadData();
                
                QuestionsList.ItemsSource = _allQuestions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
