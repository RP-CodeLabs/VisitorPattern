using System.Collections.Generic;
using System.Linq;
using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public class CollectViewBuilders : ICollectViewBuilders
    {
        public IEnumerable<ViewModel> GetViewModels(Context context, params IViewModelBuilder[] viewModelBuilders)
        {
            return viewModelBuilders.Select(viewModelBuilder => viewModelBuilder.Build(context));
        }
    }
}
