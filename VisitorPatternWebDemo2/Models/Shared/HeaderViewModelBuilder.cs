using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public class HeaderViewModelBuilder : IViewModelBuilder
    {

        public ViewModel Build(Context context)
        {
            return new HeaderViewModel();
        }
    }
}