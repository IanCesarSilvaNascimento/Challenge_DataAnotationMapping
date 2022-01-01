using Forum.Data;
using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum
{

    public class Program
    {

        public static void Main()
        {

            using var context = new ForumDataContext();

            var user = new User
            {
                Name = "Goku SSJ3",
                Slug = "gokussj3",
                Email = "teste4@gmail.com",
                Bio = "MVP dragon ball",
                Image = "image teste",
                PasswordHash = "123098457"
            };

            var category = new Category
            {
                Name = "Testando Fundamento EF core",
                Slug = "testando-fundamento-ef-core"
            };

            var post = new Post
            {
                category = category,
                Body = "<p>Hello world</p>",
                Slug = "testando-fundamento", 
                Summary = "Neste artigo vamos testar",
                Title = "Começando a testar",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            context.Users.Add(user);
            context.Posts.Add(post);
            context.SaveChanges();

            //Listando usuários do banco
            var items = context
                .Users
                .AsNoTracking()
                .ToList();

            foreach (var item in items)
                Console.WriteLine(item.Name);





        }

    }
}