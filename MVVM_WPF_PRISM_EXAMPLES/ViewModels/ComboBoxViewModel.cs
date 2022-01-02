using MVVM_WPF_PRISM_EXAMPLES.Models;
using Prism.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVM_WPF_PRISM_EXAMPLES.ViewModels
{
    public class ComboBoxViewModel : ViewModelBase
    {
        public ComboBoxViewModel()
        {
            SetCarrosNaLista();
        }

        private DelegateCommand selectCommand;
        public DelegateCommand SelectCommand =>
            selectCommand ?? (selectCommand = new DelegateCommand(SelecionarItem));

        private string totalSelecionados;

        public string TotalSelecionados
        {
            get { return totalSelecionados; }
            set { SetProperty(ref totalSelecionados, value); }
        }

        private ObservableCollection<Carro> carros = new ObservableCollection<Carro>();

        public ObservableCollection<Carro> Carros
        {
            get { return carros; }
            set { SetProperty(ref carros, value); }
        }

        public void SetCarrosNaLista()
        {
            Carros.Add(new Carro { Id = 1, Ano = 2020, Marca = "GM", Modelo = "ÔNIX", Selecionado = false });
            Carros.Add(new Carro { Id = 2, Ano = 2010, Marca = "GM", Modelo = "CORSA", Selecionado = false });
            Carros.Add(new Carro { Id = 3, Ano = 2018, Marca = "VOLKS", Modelo = "UP", Selecionado = false });
            Carros.Add(new Carro { Id = 4, Ano = 2017, Marca = "PEUGEOT", Modelo = "206", Selecionado = false });
            Carros.Add(new Carro { Id = 5, Ano = 2019, Marca = "FIAT", Modelo = "MOBI", Selecionado = false });
        }

        public void SelecionarItem()
        {
            TotalSelecionados = $"Total de carros Selecionados: {Carros.Where(x => x.Selecionado).Count()}";
        }

    }
}
