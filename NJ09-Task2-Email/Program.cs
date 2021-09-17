using System;
using System.Collections.Generic;

namespace NJ09_Task2_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalBuilder();
            FluentBuilder();
        }

        static void NormalBuilder()
        {
            EmailConcreteBuilder builder = new EmailConcreteBuilder();

            builder.AddRecipient("geza");
            builder.AddRecipient("jozsi");
            builder.AddRecipient("beno");

            builder.Title = "kamu mail";

            builder.Greeting = "greeting";
            builder.MainText = "main";
            builder.Closing = "closing";

            var result = builder.Build();

            Console.WriteLine(result);
        }

        static void FluentBuilder()
        {
            IEmailGreetingBuilder builder = new EmailConcreteFluentBuilder();
            var result = builder.SetGreeting("greeting")
                .SetMainText("main")
                .SetClosing("closing")
                .SetRecipients(new HashSet<string>() { "geza", "jozsi" })
                .SetTitle("title")
                .Build();

            Console.WriteLine(result);
        }
    }
}
