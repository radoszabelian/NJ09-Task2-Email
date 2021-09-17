using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJ09_Task2_Email
{
    public class EmailConcreteBuilder : IEmailBuilder
    {
        private string title = "";
        private HashSet<string> recipients = new HashSet<string>();
        private string greeting = "";
        private string mainText = "";
        private string closing = "";

        public void AddRecipient(string recipient)
        {
            recipients.Add(recipient);
        }

        public void RemoveRecipient(string recipient)
        {
            recipients.Remove(recipient);
        }

        public string Title
        {
            set
            {
                title = value;
            }
        }

        public string Greeting
        {
            set
            {
                greeting = value;
            }
        }

        public string MainText {
            set
            {
                mainText = value;
            }
        }

        public string Closing
        {
            set
            {
                closing = value;
            }
        }

        public Email Build()
        {
            return new Email(title, Utility.StringWithCommas(recipients), $"{greeting} {mainText} {closing}");
        }
    }
}
