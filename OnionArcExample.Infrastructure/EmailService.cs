using OnionArcExample.Infrastructure.Interfaces.Services;

namespace OnionArcExample.Infrastructure
{
    internal class EmailService : IEmailService
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine("mail sent");
            return true;
        }
    }
}
