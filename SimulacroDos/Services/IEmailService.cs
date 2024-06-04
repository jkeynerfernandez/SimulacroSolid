namespace SimulacroDos.Services
{
    public interface IEmailService
    {
        void SendEmail(string toEmail, string subject, string body);
    }
}
