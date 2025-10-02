// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using App;


List<User> users = new List<User>();
users.Add(new User("plick@fashion.se", "pass2word"));

List<string> items = new List<string>();
items.Add("Sneakers 42, white");
items.Add("Jeans M, black");
items.Add("Jacket M, black");
items.Add("Golden wrist watch");

Console.WriteLine("..Checking if my items exit...");

foreach (string item in items)
{
    Console.WriteLine(item);
}
Console.ReadLine();

User? active_user = null;

bool running = true;

while (running)
{
    try { Console.Clear(); }catch{};
    if (active_user != null)
    {
        Console.WriteLine("..Welcome to Plick..");
        Console.WriteLine("..Buy, Sell and be inspired by secondhand mood..");
    }

    else if (active_user == null)
    {
        Console.Write("Username: ");
        string? username = Console.ReadLine();

        Console.Write("Password: ");
        string? password = Console.ReadLine();
        try { Console.Clear(); } catch { };


        foreach (User user in users)
        {
            if (user.TryLogin(username, password))
            {
                active_user = user;

                break;
            }

        }
    }
    else
    {
        Console.WriteLine("Username or Passord wrong");
    }
}
