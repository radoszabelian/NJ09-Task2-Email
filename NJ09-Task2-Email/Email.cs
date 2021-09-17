using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJ09_Task2_Email
{
    public class Email
    {
        private readonly string Title;
        private readonly string Recipients;
        private readonly string Message;

        delegate void EmailSentDelegate();
        private event EmailSentDelegate EmailSent;

        public Email(string _title, string _recipients, string _message)
        {
            Title = _title;
            Recipients = _recipients;
            Message = _message;
        }

        public void Send()
        {
            if (EmailSent != null)
            {
                EmailSent.Invoke();
            }
        }

        public override string ToString()
        {
            return $"Email: title: {Title}, Recipients: {Recipients}, Message: {Message}";
        }
    }
}
