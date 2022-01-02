namespace MVVM_WPF_PRISM_EXAMPLES.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public bool Selecionado { get; set; }
        public string Nome { get { return Marca + " - " + Modelo; } }
    }
}
