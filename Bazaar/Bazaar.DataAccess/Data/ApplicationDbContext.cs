using Bazaar.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bazaar.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cooking", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Self-Help", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Adventure", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "There and back again",
                    Author = "Bilbo Baggins",
                    Description = "Dive into the narrative as Bilbo embarks on a quest that transforms him from a comfort-loving hobbit into an unlikely hero. The story is interwoven with suspense, humor, and vivid descriptions that bring to life the world of Middle-earth. There and Back Again is not just a book; it's an invitation to adventure, friendship, and the discovery of one's own potential ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80
                },
                new Product
                {
                    Id = 2,
                    Title = "Honor",
                    Author = "Eddard Stark",
                    Description = "Eddard Stark captures the essence of duty, integrity, and sacrifice that defines the Warden of the North. Through vivid storytelling and rich character exploration, readers are transported to the heart of Winterfell and the stark realities of power and loyalty in the Seven Kingdoms. This book is a tribute to the steadfastness of Eddard Stark, illustrating his unwavering commitment to justice and family amidst a world of political intrigue and betrayal.",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id = 3,
                    Title = "Potatoes",
                    Author = "Samwise Gamgee ",
                    Description = "Potatoes is a celebration of one of the Shire's most beloved staples, featuring a treasure trove of mouthwatering recipes and cooking tips. Whether you prefer them mashed, roasted, or fried, Samwise has something for everyone in this comprehensive guide to potato perfection. Join him as he shares anecdotes from his time in the kitchen and imparts the wisdom passed down from generations of hobbit cooks. With Potatoes in hand, you'll never look at this humble tuber the same way again. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35
                },
                new Product
                {
                    Id = 4,
                    Title = "How to survive outside",
                    Author = "Arya Stark",
                    Description = "How to Survive Outside is your ultimate companion for mastering the skills needed to thrive beyond the safety of city walls. From finding food and shelter to evading danger and honing your combat abilities, Arya Stark provides practical advice and cunning strategies gleaned from her own adventures across Westeros and beyond. Whether you're a seasoned explorer or a novice venturing into the unknown, this indispensable manual will equip you with the knowledge and confidence to conquer any wilderness. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55
                },
                new Product
                {
                    Id = 5,
                    Title = "Magical Creatures of Middle-earth",
                    Author = "Gandalf the Grey",
                    Description = "Embark on a fantastical journey through the realms of Middle-earth with Magical Creatures of Middle - earth by the venerable Gandalf the Grey. In this enchanting compendium, Gandalf unveils the wondrous creatures that inhabit Tolkien's richly imagined world, from noble ents and mischievous hobbits to fearsome dragons and elusive unicorns. With captivating illustrations and insightful commentary, this definitive guide offers a rare glimpse into the fauna of Middle-earth, making it a must-have for fans of fantasy and folklore alike.",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id = 6,
                    Title = "The Art of Diplomacy",
                    Author = "Tyrion Lannister",
                    Description = "Delve into the intricate world of politics and negotiation with The Art of Diplomacy by the cunning Tyrion Lannister. In this masterful treatise, Tyrion shares his unparalleled expertise on the delicate dance of power and persuasion, offering timeless lessons on diplomacy and statecraft gleaned from his own exploits in the corridors of King's Landing and beyond. Whether you aspire to navigate the treacherous waters of court intrigue or simply seek to understand the machinations of power, this insightful guide is an indispensable resource for any aspiring diplomat or seasoned ruler.",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20
                }
                );
        }
    }
}
