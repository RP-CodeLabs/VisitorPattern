using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPatternWebDemo2.Models.PricePresentation;
using VisitorPatternWebDemo2.Models.Shared;

namespace VisitorPatternWebDemo2.Tests
{
    [TestClass]
    public class ViewModelBuilderCollectorTest
    {
        private Context _context;

        [TestInitialize]
        public void Setup()
        {
            _context = new Context();
        }

        [TestMethod]
        public void should_return_empty_viewmodels_if_we_are_not_going_to_send_viewmodelbuilders()
        {
            var collector = new CollectViewBuilders();

            var result = collector.GetViewModels(_context);

            Assert.IsInstanceOfType(result, typeof(IEnumerable<ViewModel>));
        }

        [TestMethod]
        public void should_return_headerviewmodel_if_i_pass_headerviewmodelbuilder()
        {
            var collector = new CollectViewBuilders();
            var result = collector.GetViewModels(_context, new HeaderViewModelBuilder());

            Assert.IsInstanceOfType(result.First(),typeof(HeaderViewModel));
        }

        [TestMethod]
        public void should_return_viewmodels_with_count_equal_to_viewmodel_passed()
        {
            var collector = new CollectViewBuilders();
            var result = collector.GetViewModels(_context, new HeaderViewModelBuilder(), new FooterViewModelBuilder());
            Assert.IsTrue(result.Count() == 2);
        }
    }
}