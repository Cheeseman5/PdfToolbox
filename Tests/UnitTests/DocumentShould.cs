using System;
using Xunit;
using Bunit;
//using Document = PDF_Toolbox.

namespace PDF_Toolbox.Tests.UnitTests
{
    public class DocumentShould
    {
        public void Setup()
        {

        }

        [Fact]
        public void RenderWithoutIssues()
        {
            using var context = new TestContext();
            var component = context.RenderComponent<Document>();
        }
    }
}
