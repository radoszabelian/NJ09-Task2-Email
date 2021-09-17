using Microsoft.VisualStudio.TestTools.UnitTesting;
using NJ09_Task2_Email;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void TestBasicBuilding()
        {
            const string expectedRecipients = "geza, jozsi, beno";
            const string expectedTitle = "kamu mail";
            const string expectedMessage = "greeting main closing";

            EmailConcreteBuilder builder = new EmailConcreteBuilder();

            builder.AddRecipient("geza");
            builder.AddRecipient("jozsi");
            builder.AddRecipient("beno");

            builder.Title = "kamu mail";
            builder.Greeting = "greeting";
            builder.MainText = "main";
            builder.Closing = "closing";

            var result = builder.Build().ToString();

            var expectedResult = $"Email: title: {expectedTitle}, Recipients: {expectedRecipients}, Message: {expectedMessage}";

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestFluentBuilding()
        {
            const string expectedRecipients = "geza, jozsi, alfred";
            const string expectedTitle = "kamu mail";
            const string expectedMessage = "greeting main closing";

            IEmailGreetingBuilder builder = new EmailConcreteFluentBuilder();
            var result = builder.SetGreeting("greeting")
                .SetMainText("main")
                .SetClosing("closing")
                .SetRecipients(new HashSet<string>() { "geza", "jozsi", "alfred" })
                .SetTitle(expectedTitle)
                .Build()
                .ToString();

            var expectedResult = $"Email: title: {expectedTitle}, Recipients: {expectedRecipients}, Message: {expectedMessage}";

            Assert.AreEqual(expectedResult, result);
        }
    }
}
