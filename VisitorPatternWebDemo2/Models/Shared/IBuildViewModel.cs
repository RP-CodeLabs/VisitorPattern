using VisitorPatternWebDemo2.Models.PricePresentation;

namespace VisitorPatternWebDemo2.Models.Shared
{
    public interface IBuildViewModel<out T> 
    {
        T Build(); 
    }
}