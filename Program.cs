namespace EmailSender;
using Classes;
class Program
{
    static void Main(string[] args)
    {
        EnviaEmail email = new EnviaEmail();
        System.Console.WriteLine("Digite o seu email: ");
        var seuEmail = Console.ReadLine();
        System.Console.WriteLine("Digite a senha do seu email: ");
        var senhaEmail = Console.ReadLine();
        System.Console.WriteLine("Digite o email do destinatário: ");
        var emailDestinatario = Console.ReadLine();
        System.Console.WriteLine("Digite o Assunto do email: ");
        var assunto = Console.ReadLine();
        System.Console.WriteLine("Digite a mensagem: ");
        var mensagem = Console.ReadLine();
        Console.WriteLine("Enviando email");
        email.Email(assunto, mensagem, seuEmail,senhaEmail, emailDestinatario);
    }
}
