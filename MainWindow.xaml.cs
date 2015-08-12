using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StackOverflowWizardExample
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
    }

    public class MainViewModel
    {
        public PageViewModel Page1VM
        {
            get;
            set;
        }

        public PageViewModel Page2VM
        {
            get;
            set;
        }

        public MainViewModel()
        {
            this.Page1VM = new PageViewModel("Page 1");
            this.Page2VM = new PageViewModel("Page 2");
        }
    }

    public class PageViewModel
    {
        public string Title { get; set; }
        public PageViewModel(string title) { this.Title = title; }
    }
}
