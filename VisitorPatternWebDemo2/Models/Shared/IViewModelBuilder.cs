using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public interface IViewModelBuilder
    {
        ViewModel Build(Context context);
    }
}