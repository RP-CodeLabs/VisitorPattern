using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VisitorPatternWebDemo2.Controllers;
using VisitorPatternWebDemo2.Models.Shared;

namespace VisitorPatternWebDemo2.Tests.Controllers
{
    [TestClass]
    public class PricePresentationControllerTest
    {
        [TestMethod]
        public void pricepresentation_should_return_presentationmodel(Context buildContext)
        {
            var context = new Mock<IBuildContext>();
            var builder = new Mock<IPresentationModelBuilder>();
            context.Setup(x => x.BuildContext()).Returns(new Context());
            builder.Setup(x => x.Build(buildContext)).Returns(new PresentationModel());
            var controller = new PricePresentationController(context.Object, builder.Object);
            var model = controller.PricePresentation();
            Assert.IsInstanceOfType(model,typeof(PresentationModel));
        }
    }
}
