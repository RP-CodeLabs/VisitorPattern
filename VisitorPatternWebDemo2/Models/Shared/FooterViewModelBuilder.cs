using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public class FooterViewModelBuilder: IViewModelBuilder
    {
        public ViewModel Build(Context context)
        {
            return new FooterViewModel();
        }
    }
}