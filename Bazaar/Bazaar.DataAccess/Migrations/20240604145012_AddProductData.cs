using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bazaar.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Bilbo Baggins", "Dive into the narrative as Bilbo embarks on a quest that transforms him from a comfort-loving hobbit into an unlikely hero. The story is interwoven with suspense, humor, and vivid descriptions that bring to life the world of Middle-earth. There and Back Again is not just a book; it's an invitation to adventure, friendship, and the discovery of one's own potential ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "There and back again" },
                    { 2, "Eddard Stark", "Eddard Stark captures the essence of duty, integrity, and sacrifice that defines the Warden of the North. Through vivid storytelling and rich character exploration, readers are transported to the heart of Winterfell and the stark realities of power and loyalty in the Seven Kingdoms. This book is a tribute to the steadfastness of Eddard Stark, illustrating his unwavering commitment to justice and family amidst a world of political intrigue and betrayal.", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Honor" },
                    { 3, "Samwise Gamgee ", "Potatoes is a celebration of one of the Shire's most beloved staples, featuring a treasure trove of mouthwatering recipes and cooking tips. Whether you prefer them mashed, roasted, or fried, Samwise has something for everyone in this comprehensive guide to potato perfection. Join him as he shares anecdotes from his time in the kitchen and imparts the wisdom passed down from generations of hobbit cooks. With Potatoes in hand, you'll never look at this humble tuber the same way again. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Potatoes" },
                    { 4, "Arya Stark", "How to Survive Outside is your ultimate companion for mastering the skills needed to thrive beyond the safety of city walls. From finding food and shelter to evading danger and honing your combat abilities, Arya Stark provides practical advice and cunning strategies gleaned from her own adventures across Westeros and beyond. Whether you're a seasoned explorer or a novice venturing into the unknown, this indispensable manual will equip you with the knowledge and confidence to conquer any wilderness. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "How to survive outside" },
                    { 5, "Gandalf the Grey", "Embark on a fantastical journey through the realms of Middle-earth with Magical Creatures of Middle - earth by the venerable Gandalf the Grey. In this enchanting compendium, Gandalf unveils the wondrous creatures that inhabit Tolkien's richly imagined world, from noble ents and mischievous hobbits to fearsome dragons and elusive unicorns. With captivating illustrations and insightful commentary, this definitive guide offers a rare glimpse into the fauna of Middle-earth, making it a must-have for fans of fantasy and folklore alike.", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Magical Creatures of Middle-earth" },
                    { 6, "Tyrion Lannister", "Delve into the intricate world of politics and negotiation with The Art of Diplomacy by the cunning Tyrion Lannister. In this masterful treatise, Tyrion shares his unparalleled expertise on the delicate dance of power and persuasion, offering timeless lessons on diplomacy and statecraft gleaned from his own exploits in the corridors of King's Landing and beyond. Whether you aspire to navigate the treacherous waters of court intrigue or simply seek to understand the machinations of power, this insightful guide is an indispensable resource for any aspiring diplomat or seasoned ruler.", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "The Art of Diplomacy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
