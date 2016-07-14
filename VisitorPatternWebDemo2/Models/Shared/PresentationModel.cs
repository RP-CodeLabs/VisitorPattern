using System.Collections.Generic;
using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public class PresentationModel
    {
        public PresentationModel()
        {
            ViewModels = new List<ViewModel>();
        }
        public List<ViewModel> ViewModels { get; set; }
    }
}