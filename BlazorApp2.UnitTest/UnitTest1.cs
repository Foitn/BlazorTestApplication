using BlazorApp2.Pages;
using Bunit;

namespace BlazorApp2.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange: render the Counter.razor component
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<FetchData>();

            // Act: find and click the <button> element to increment
            // the counter in the <p> element
            cut.Find("#AwesomeButton").Click();

            // Assert: first find the <p> element, then verify its content
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
        [Fact]
        public void Test2()
        {
            // Arrange: render the Counter.razor component
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();

            // Act: find and click the <button> element to increment
            // the counter in the <p> element
            cut.Find("button").Click();
            cut.Find("button").Click();

            // Assert: first find the <p> element, then verify its content
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 2</p>");
        }
    }
}