using System.Web.Mvc;
using VisitorPatternWebDemo2.Models.Shared;

namespace VisitorPatternWebDemo2.Controllers
{
    public class PricePresentationController : Controller
    {
        private readonly IPresentationModelBuilder _presentationModelBuilder;
        private readonly IBuildContext _contextBuilder;

        public PricePresentationController(IBuildContext contextBuilder, IPresentationModelBuilder presentationModelBuilder)
        {
            _contextBuilder = contextBuilder;
            _presentationModelBuilder = presentationModelBuilder;
        }
        
        public PresentationModel PricePresentation()
        {
            return _presentationModelBuilder.Build(_contextBuilder.BuildContext());
        }
    }
}