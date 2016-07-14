using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPatternWebDemo2.Models.PricePresentation;
using VisitorPatternWebDemo2.Models.Shared;

namespace VisitorPatternWebDemo2.Tests.PresentationModelBuilder
{
    [TestClass]
    public class CreateInstanceTests
    {
        [TestMethod]
        public void should_create_new_instance_of_given_type()
        {
            ICreateInstance<PricePresentationModel> instanceFactory = new CreateInstance<PricePresentationModel>();
            var instance = instanceFactory.Create();
            Assert.IsNotNull(instance);
        }
    }
}