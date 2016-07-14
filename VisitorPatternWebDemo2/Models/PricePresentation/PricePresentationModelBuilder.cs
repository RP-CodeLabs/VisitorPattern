using VisitorPatternWebDemo2.Models.Shared;

namespace VisitorPatternWebDemo2.Models.PricePresentation
{
    public class PricePresentationModelBuilder : IPresentationModelBuilder
    {
        private readonly ICreateInstance<PricePresentationModel> _pricePresentationModel;
        private readonly ICollectViewBuilders _collectViewBuilders;
        private readonly HeaderViewModelBuilder _headerViewModelBuilder;
        private readonly FooterViewModelBuilder _footerViewModelBuilder;

        public PricePresentationModelBuilder(ICreateInstance<PricePresentationModel> pricePresentationModel, ICollectViewBuilders collectViewBuildersCollector, HeaderViewModelBuilder headerViewModelBuilder, FooterViewModelBuilder footerViewModelBuilder)
        {
            _pricePresentationModel = pricePresentationModel;
            _collectViewBuilders = collectViewBuildersCollector;
            _headerViewModelBuilder = headerViewModelBuilder;
            _footerViewModelBuilder = footerViewModelBuilder;
        }

        public PresentationModel Build(Context context) 
        {
            var pricePresentationModel = _pricePresentationModel.Create();
            pricePresentationModel.ViewModels.AddRange(_collectViewBuilders.GetViewModels(context, _headerViewModelBuilder, _footerViewModelBuilder));
            return pricePresentationModel; 
        }
    }
}