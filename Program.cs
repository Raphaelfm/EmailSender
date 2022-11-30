namespace EmailSender;
using Classes;
class Program
{
    static void Main(string[] args)
    {
        EnviaEmail email = new EnviaEmail();
        System.Console.WriteLine("Digite o seu email: ");
        string seuEmail = Console.ReadLine();
        System.Console.WriteLine("Digite a senha do seu email: ");
        string senhaEmail = Console.ReadLine();
        System.Console.WriteLine("Digite o email do destinatário: ");
        string emailDestinatario = Console.ReadLine();
        System.Console.WriteLine("Digite o Assunto do email: ");
        string assunto = Console.ReadLine();
        System.Console.WriteLine("Digite a mensagem: ");
        string mensagem = Console.ReadLine();
        Console.WriteLine("Enviando email");
        email.Email(assunto, mensagem, seuEmail,senhaEmail, emailDestinatario);
    }
}
