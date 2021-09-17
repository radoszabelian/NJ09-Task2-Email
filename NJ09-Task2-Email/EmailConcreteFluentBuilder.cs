using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJ09_Task2_Email
{
    public class EmailConcreteFluentBuilder : IEmailBuilder, IEmailRecipientsBuilder, IEmailTitleBuilder, IEmailGreetingBuilder, IEmailMainTextBuilder, IEmailClosingBuilder
    {
        private string title;
        private HashSet<string> recipients;
        private string closing;
        private string greeting;
        private string mainText;

        public Email Build()
        {
            return new Email(title, Utility.StringWithCommas(recipients), $"{greeting} {mainText} {closing}");
        }

        public IEmailRecipientsBuilder SetClosing(string closing)
        {
            this.closing = closing;

            return this;
        }

        public IEmailMainTextBuilder SetGreeting(string greeting)
        {
            this.greeting = greeting;

            return this;
        }

        public IEmailClosingBuilder SetMainText(string mainText)
        {
            this.mainText = mainText;

            return this;
        }

        public IEmailTitleBuilder SetRecipients(HashSet<string> recipients)
        {
            this.recipients = recipients;

            return this;
        }

        public IEmailBuilder SetTitle(string title)
        {
            this.title = title;

            return this;
        }
    }

    public interface IEmailGreetingBuilder
    {
        IEmailMainTextBuilder SetGreeting(string greeting);
    }

    public interface IEmailMainTextBuilder
    {
        IEmailClosingBuilder SetMainText(string mainText);
    }

    public interface IEmailClosingBuilder
    {
        IEmailRecipientsBuilder SetClosing(string closing);
    }

    public interface IEmailRecipientsBuilder
    {
        IEmailTitleBuilder SetRecipients(HashSet<string> recipients);
    }

    public interface IEmailTitleBuilder
    {
        IEmailBuilder SetTitle(string title);
    }
}
