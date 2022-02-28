using TestTaskQulix.Context;
using TestTaskQulix.Models;

namespace TestTaskQulix
{
    public static class DatabaseInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Author
                    {
                        AuthorName = "Igor",
                        Nickname = "Ogorek",
                        Age = 25,
                        DateOfAccCreation = DateTime.Now
                    },
                    new Author
                    {
                        AuthorName = "Topo",
                        Nickname = "Topopo",
                        Age = 27,
                        DateOfAccCreation = DateTime.Now
                    }
                ); 
                context.SaveChanges();
            }
            if (!context.Photos.Any())
            {
                context.Photos.AddRange(
                    new Photo
                    {
                        PhotoName = "Picture1",
                        ContentLink = "sdfsdfsdfsd",
                        PhotoSize = "25x25",
                        PhotoCreatedDate = DateTime.Now,
                        AuthorId=1,
                        PhotoCost=24.45,
                        PhotoNumberOfPurchase=10,
                        PhotoRating= 9
                    },
                    new Photo
                    {
                        PhotoName = "Picture2",
                        ContentLink = "afdasfa",
                        PhotoSize = "50x50",
                        PhotoCreatedDate = DateTime.Now,
                        AuthorId = 1,
                        PhotoCost = 26.75,
                        PhotoNumberOfPurchase = 12,
                        PhotoRating = 8
                    },
                    new Photo
                    {
                        PhotoName = "Picture3",
                        ContentLink = "wwwwwww",
                        PhotoSize = "40x40",
                        PhotoCreatedDate = DateTime.Now,
                        AuthorId = 2,
                        PhotoCost = 55.23,
                        PhotoNumberOfPurchase = 5,
                        PhotoRating = 7
                    }
                );
                context.SaveChanges();
            }
            if (!context.Texts.Any())
            {
                context.Texts.AddRange(
                    new Text
                    {
                        TextName = "Text1",
                        TextContent = "TTTTTT",
                        TextSize = "34",
                        TextCreateDate = DateTime.Now,
                        TextCost = 12.25,
                        AuthorId = 1,
                        TextNumberOfPurches = 12
                    },
                    new Text
                    {
                        TextName = "Text2",
                        TextContent = "DDDDDDD",
                        TextSize = "45",
                        TextCreateDate = DateTime.Now,
                        TextCost = 17.25,
                        AuthorId = 2,
                        TextNumberOfPurches = 15
                    },
                    new Text
                    {
                        TextName = "Text3",
                        TextContent = "FFFFFFFF",
                        TextSize = "56",
                        TextCreateDate = DateTime.Now,
                        TextCost = 18.4,
                        AuthorId = 2,
                        TextNumberOfPurches = 15
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
