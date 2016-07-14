using System.Collections.Generic;
using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public interface ICollectViewBuilders
    {
        IEnumerable<ViewModel> GetViewModels(Context context, params IViewModelBuilder[] viewModelBuilders);
    }
}