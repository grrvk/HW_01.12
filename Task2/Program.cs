//Поришуно Принцип єдиного обовʼязку
using System;

class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}
class EmailSender
{
    public void Send(Email email)
    {
        Console.WriteLine("Повідомлення відправлено");
    }
}

class PrintManager
{
    public void Print(Email email)
    {
        Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Who are you?"
        };
        Email e2 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "vacuum cleaners!"
        };
        Email e3 = new Email()
        {
            From = "Kolya",
            To = "Vasya",
            Theme = "No! Thanks!"
        };
        Email e4 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "washing machines!"
        };
        Email e5 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Yes"
        };
        Email e6 = new Email()
        {
            From = "Vasya",
            To = "Petya",
            Theme = "+2"
        };

        List<Email> emails = new List<Email>();
        EmailSender es = new EmailSender();
        PrintManager prM = new PrintManager();

        emails.Add(e1);
        emails.Add(e2);
        emails.Add(e3);
        emails.Add(e4);
        emails.Add(e5);
        emails.Add(e6);
        foreach (Email el in emails){
            es.Send(el);
            prM.Print(el);
        }
        Console.ReadKey();
    }
}