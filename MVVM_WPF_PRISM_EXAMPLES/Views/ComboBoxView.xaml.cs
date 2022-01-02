using MVVM_WPF_PRISM_EXAMPLES.ViewModels;
using System.Windows.Controls;

namespace MVVM_WPF_PRISM_EXAMPLES.Views
{
    /// <summary>
    /// Interaction logic for ComboBoxView.xaml
    /// Exemplo COMBOBOX-MULTISELECT
    /// </summary>
    public partial class ComboBoxView : UserControl
    {
        public ComboBoxView()
        {
            InitializeComponent();
            DataContext = new ComboBoxViewModel();
        }
    }
}
