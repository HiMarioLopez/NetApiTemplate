using System.Threading.Tasks;
using MyOnionApi.Application.DTOs.Email;

namespace MyOnionApi.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}