using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for WizardControl.xaml
    /// </summary>
    public partial class WizardControl : UserControl
    {
        public WizardControl()
        {
            InitializeComponent();
        }

        public WizardPageCollection Pages
        {
            get { return (WizardPageCollection)GetValue(PagesProperty); }
            set { SetValue(PagesProperty, value); }
        }

        public static readonly DependencyProperty PagesProperty =
            DependencyProperty.Register("Pages", typeof(WizardPageCollection), typeof(WizardControl), new PropertyMetadata(new WizardPageCollection(), new PropertyChangedCallback(Pages_Changed)));

        static void Pages_Changed(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            WizardPageCollection col =  e.NewValue as WizardPageCollection;
            WizardControl ctrl = obj as WizardControl;
            ctrl.contentPage.Content = col.First();
        }
    }

    public class WizardPageCollection : ObservableCollection<WizardPageBase> { }

    public class WizardPageBase : ContentControl { }
}
