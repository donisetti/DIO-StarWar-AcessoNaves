using System.Collections.Generic;

namespace StarWarNaves.Servicos.ViewModels
{
    public class ResultadoApi<ViewModel>
    {
        public string Next { get; set; }
        public IReadOnlyList<ViewModel> Results { get; set; }
    }
}
