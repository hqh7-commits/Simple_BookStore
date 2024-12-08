using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "TechSo", StreetAddress="123 Tech St", City="Tech City", PostalCode="123123", State="RD", PhoneNumber="9999999999" },
                new Company { Id = 2, Name = "ViDi", StreetAddress = "456 Tech St", City = "Tech City", PostalCode = "123123", State = "RD", PhoneNumber = "8888888888" },
                new Company { Id = 3, Name = "RanDo", StreetAddress = "789 Tech St", City = "Tech City", PostalCode = "123123", State = "RD", PhoneNumber = "7777777777" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Thám Tử Sherlock Holmes",
                    Author = "Arthur Conan Doyle",
                    Description = "Tên tôi là Sherlock Holmes. Công việc của tôi là để biết những gì mà người khác không biết…\r\n\r\nChỉ từ một giọt nước, người giỏi suy luận có thể suy ra khả năng của một đại dương hoặc một thác nước, tuy chưa bao giờ tận mắt nhìn thấy chúng. Như vậy, toàn bộ cuộc sống là một chuỗi mắt xích rộng lớn mà ta có thể biết bản chất của nó, nếu ta biết được một mắt xích…\r\n\r\nSherlock Holmes – thám tử tư vĩ đại nhất trong văn học thế giới. Lạnh lùng, quyết đoán, dũng cảm, giàu lòng chính nghĩa, tài quan sát đáng kinh ngạc, khả năng suy luận tuyệt vời nhờ vào những chứng cứ khó ngờ nhất khám phá ra chân tướng ẩn giấu sau những sự thực bị bẻ cong hình thành một kinh điển bất hủ trong lĩnh vực văn học trinh thám.\r\n\r\nSherlock Holmes đã xuất hiện trong 4 tiểu thuyết và 56 truyện ngắn của nhà văn Conan Doyle. Hầu như tất cả các tác phẩm đều được viết dưới dạng ghi chép của bác sĩ John H. Watson, người bạn thân thiết và người ghi chép tiểu sử của Holmes, chỉ có 2 tác phẩm được viết dưới dạng ghi chép của chính Holmes và 2 tác phẩm khác dưới dạng ghi chép của người thứ 3.",
                    ISBN = "8935095626915",
                    ListPrice = 99000,
                    Price = 88000,
                    Price50 = 77000,
                    Price100 = 66000,
                    CategoryId = 1,
                    ImageUrl = "/images/product/sherlock_holmes.jpg",
                },
                new Product
                {
                    Id = 2,
                    Title = "Jack Reacher - Book 28 - The Secret",
                    Author = "Lee Child",
                    Description = "The gripping new Jack Reacher thriller from the #1 New York Times bestselling authors Lee Child and Andrew Child A string of mysterious deaths. A long-classified mission. A young MP with nothing to lose. 1992. All across the United States respectable, upstanding citizens are showing up dead. These deaths could be accidents, and they don’t appear to be connected—until a fatal fall from a high-floor window attracts some unexpected attention. That attention comes from the secretary of defense. All of a sudden he wants an interagency task force to investigate. And he wants Jack Reacher as the army’s representative. If Reacher gets a result, great. If not, he’s a convenient fall guy. But office politics isn’t Reacher’s thing.",
                    ISBN = "9780593871454",
                    ListPrice = 197000,
                    Price = 180000,
                    Price50 = 160000,
                    Price100 = 140000,
                    CategoryId = 1,
                    ImageUrl = "/images/product/jack_reacher.jpg",
                },
                new Product
                {
                    Id = 3,
                    Title = "The Hunger Games Box Set (Book 1 - 4)",
                    Author = "Suzanne Collins",
                    Description = "This beautiful paperback box set includes all three books in Suzanne Collins's internationally bestselling Hunger Games trilogy together with The Ballad of Songbirds and Snakes.\r\n\r\nIn the ruins of a place once known as North America lies the nation of Panem, a shining Capitol surrounded by twelve outlying districts. The Capitol keeps the districts in line by forcing them all to send one boy and one girl between the ages of twelve and eighteen to participate in the annual Hunger Games, a fight to the death on live TV... And the odds are against all who play. With all four of Suzanne Collins's Hunger Games novels in one box set, you can step into the world of Panem with the 10th annual Hunger Games, and continue all the way to the electrifying conclusion.",
                    ISBN = "9781339042657-bq",
                    ListPrice = 1173300,
                    Price = 1000000,
                    Price50 = 950000,
                    Price100 = 800000,
                    CategoryId = 1,
                    ImageUrl = "/images/product/hunger_games.jpg",
                },
                new Product
                {
                    Id = 4,
                    Title = "Dune Saga Boxed Set (Book 1 - 3)",
                    Author = "Frank Herbert",
                    Description = "Perfect for longtime fans and new readers alike—a beautiful premium mass market boxed set of the first three novels in Frank Herbert's Dune Saga.\r\n\r\nIn the far future, on a remote planet, an epic adventure awaits. Here are the first three novels of Frank Herbert’s magnificent Dune saga—a triumph of the imagination and one of the bestselling science fiction series of all time.",
                    ISBN = "9780593201893-bq",
                    ListPrice = 590000,
                    Price = 550000,
                    Price50 = 500000,
                    Price100 = 400000,
                    CategoryId = 2,
                    ImageUrl = "/images/product/dune.jpg",
                },
                new Product
                {
                    Id = 5,
                    Title = "Harry Potter - A History of Magic",
                    Author = "J.K. Rowling",
                    Description = "An irresistible romp through the history of magic, from alchemy to unicorns, ancient witchcraft to Harry's Hogwarts - packed with unseen sketches and manuscript pages from J.K. Rowling, magical illustrations from Jim Kay and weird, wonderful and inspiring artefacts that have been magically released from the archives at the British Library.\r\n\r\nThis spellbinding book takes readers on a journey through the Hogwarts curriculum, including Herbology, Defence Against the Dark Arts, Astronomy, Divination and more. Discover the truth behind making the Philosopher's Stone, create your very own potion and uncover the secret of invisible ink. Learn all about the history of mandrake roots and dragons, discover what witches really used their brooms for, pore over incredible images of actual mermaids and read about real-life potions, astronomers and alchemists.\r\n\r\nThe perfect gift for aspiring witches and wizards and any Harry Potter fan. Celebrating twenty years of Harry Potter magic, and produced in association with the British Library to support their major exhibition, Harry Potter: A History of Magic.",
                    ISBN = "9781408890776",
                    ListPrice = 365000,
                    Price = 320000,
                    Price50 = 280000,
                    Price100 = 250000,
                    CategoryId = 2,
                    ImageUrl = "/images/product/harry_potter.jpg",
                },
                new Product
                {
                    Id = 6,
                    Title = "Việt Nam Sử Lược (Tái bản 2022)",
                    Author = "Trần Trọng Kim",
                    Description = "Trần Trọng Kim (1883 - 1953) là một học giả danh tiếng đầu thế kỷ XX, cùng thời với những tên tuổi lớn như Phạm Quỳnh, Nguyễn Văn Vĩnh… Với bút hiệu Lệ Thần, ông đã có nhiều thành tựu trong lĩnh vực khảo cứu, biên soạn, dịch thuật, để lại cho đời nhiều tác phẩm có giá trị về lịch sử, văn hóa như Việt Nam sử lược, Việt Nam văn phạm, Nho giáo...\r\n\r\nViệt Nam sử lược là cuốn sách lịch sử Việt Nam đầu tiên viết bằng chữ quốc ngữ, hệ thống lại toàn bộ lịch sử nước Việt (cho đến thời kỳ Pháp thuộc).",
                    ISBN = "8935236412926",
                    ListPrice = 175000,
                    Price = 155000,
                    Price50 = 125000,
                    Price100 = 100000,
                    CategoryId = 3,
                    ImageUrl = "/images/product/su_vn.jpg",
                }
                );
        }
    }
}
