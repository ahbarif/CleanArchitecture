using CleanArchitecture.Application.Models;

namespace CleanArchitecture.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Email email);
    }
}
