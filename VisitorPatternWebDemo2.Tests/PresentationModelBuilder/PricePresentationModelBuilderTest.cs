using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VisitorPatternWebDemo2.Models.PricePresentation;
using VisitorPatternWebDemo2.Models.Shared;

namespace VisitorPatternWebDemo2.Tests.PresentationModelBuilder
{
    [TestClass]
    public class PricePresentationModelBuilderTest
    {
        private PricePresentationModelBuilder _presentationModelBuilder;
        private PresentationModel _presentationModel;

        [TestInitialize]
        public void Setup()
        {
            var presentationModel = new CreateInstance<PricePresentationModel>();
            var presentationModelMock = new Mock<ICreateInstance<PricePresentationModel>>();
            presentationModelMock.Setup(x => x.Create()).Returns(new PricePresentationModel());
            
            var viewModelBuilderMock = new Mock<ICollectViewBuilders>();
            var headerViewModelBuilder = new HeaderViewModelBuilder();
            var footerViewModelBuilder = new FooterViewModelBuilder();
            var itemsToReturn = new ViewModel[] { new HeaderViewModel(), new FooterViewModel() };
            viewModelBuilderMock.Setup(x => x.GetViewModels(It.IsAny<Context>(),It.IsAny<IViewModelBuilder[]>())).Returns(itemsToReturn);
            
            _presentationModelBuilder = new PricePresentationModelBuilder(presentationModel, viewModelBuilderMock.Object, headerViewModelBuilder, footerViewModelBuilder);
        }

        [TestMethod]
        public void build_should_return_presentationmodel_with_viewmodel_count_equal_to_two()
        {
            _presentationModel = _presentationModelBuilder.Build(new Context());
            Assert.IsTrue(_presentationModel.ViewModels.Count() == 2);
        }
    }
}
