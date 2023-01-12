// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Data;
using ConsoleApp3.Models;


Console.WriteLine("Hello, World!");
using (var db = new BlogContext())
{
    db.Blogs.Add(new Blog { Name = "Another Blog " });
    db.SaveChanges();

    foreach (var blog in db.Blogs)
    {
        Console.WriteLine(blog.Name);
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();