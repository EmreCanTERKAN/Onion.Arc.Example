using System;
using System.Collections.Generic;


namespace OnionArcExample.Infrastructure.Interfaces.Services
{
    public interface IEmailService
    {
        bool Send(string to, string message);
    }
}
