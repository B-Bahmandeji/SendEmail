namespace EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        void SendEmailHtml(Message message);
    }
}
