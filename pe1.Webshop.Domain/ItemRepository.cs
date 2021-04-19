using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pe1.Webshop.Domain
{
    public class ItemRepository
    {
        public IEnumerable<Item> GetItems()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            CollectionsRepository collectionsRepository = new CollectionsRepository();
            PropertyRepository propertyRepository = new PropertyRepository();

            return new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "Dames hoodie",
                    Img="/images/pexels-bogdan-glisik-1661471.jpg",
                    ShortDescr="Voel je comfy en hip in deze prachtige hoodie",
                    Price=55,
                    Category =  categoryRepository.GetCategories().First(d => d.Id == 2),
                    Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                    Property = propertyRepository.GetProperties().First(d => d.Id == 3)
                },
                new Item
                {
                    Id = 2,
                    Name = "Armband voor dames",
                    Img="/images/pexels-godisable-jacob-1191536.jpg",
                    ShortDescr="Gouden armband met Swarovski kristallen ",
                    Price=150,
                    Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 2),
                    Collections = collectionsRepository.GetCollections().First(col=>col.Id==1),
                    Property = propertyRepository.GetProperties().First(d => d.Id == 3)
                },
                new Item
                {
                    Id = 3,
                    Name = "Fila Disruptor II",
                    Img="/images/pexels-melvin-buezo-2529148.jpg",
                    ShortDescr="Een hippe damessneaker van Fila. Een must-have",
                    Price=118,
                    Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 2),
                     Collections = collectionsRepository.GetCollections().First(col=>col.Id==3),
                     Property = propertyRepository.GetProperties().First(d => d.Id == 1)
                },
                new Item
                {
                    Id = 4,
                    Name = "Adidas T-shirt",
                    Img="/images/pexels-david-geib-3268529.jpg",
                    ShortDescr="Een hippe T-shirt van Adidas, altijd van pas",
                    Price=20,
                    Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 2),
                     Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                     Property = propertyRepository.GetProperties().First(d => d.Id == 4)
                },
                 new Item
                {
                    Id = 5,
                    Name ="Dames broek",
                   Img="/images/pexels-heitor-verdi-2343661.jpg",
                   ShortDescr="Maak eindeloos veel combinaties met een jeansbroek",
                   Price=70,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 2),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 5)
                },

                new Item
                {
                    Id =6,
                    Name ="Heren hoodie",
                    Img="/images/pexels-aidan-jarrett-634785.jpg",
                    ShortDescr="Heerlijk comfortabel hoodie met kap voor alle dagen",
                    Price=55,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 1),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 1)
                },
                new Item
                {
                    Id = 7,
                    Name ="Armband voor heren",
                    Img="/images/pexels-ba-tik-3754202.jpg",
                    ShortDescr="Stoere armband voor modieuze mannen",
                    Price=50,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 1),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==1),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 5)
                },
                new Item
                {
                    Id = 8,
                    Name ="Broek",
                    Img="/images/pexels-cottonbro-4928951.jpg",
                    ShortDescr="Sportieve jeansbroek voor sportieve mannen",
                    Price=65,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 1),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 4)
                },
                new Item
                {
                    Id = 9,
                    Name ="Nike Air Max",
                    Img="/images/pexels-arthur-ogleznev-1102777.jpg",
                    ShortDescr="Comfortabele en sprotieve sneakers voor mannen",
                    Price=55,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 1),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==3),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 1)
                },

                 new Item
                {
                    Id = 10,
                    Name ="G-star T-shirt",
                    Img="/images/pexels-tubarones-photography-3026284.jpg",
                    ShortDescr="De perfecte pasvorm voor elke man voor elke dag",
                    Price=45,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 1),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 2)
                },



                new Item
                {
                    Id = 11,
                    Name ="Kids hoodie",
                    Img="/images/pexels-norma-mortenson-7303186.jpg",
                    ShortDescr="Stoere roblox hoodie met lange mouwen voor stoere kids",
                    Price=35,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 3),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 3)
                },

                 new Item
                {
                    Id = 12,
                    Name ="Kids pet",
                    Img="/images/pexels-hồng-xuân-viên-2869318.jpg",
                    ShortDescr="Lieve kindjes verdienen een mooie pet",
                    Price=10,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 3),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==1),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 3)
                },

                  new Item
                {
                    Id = 13,
                    Name ="Kinderbroeken",
                    Img="/images/pexels-đặng-thanh-tú-5693888.jpg",
                    ShortDescr="Modieuse broek voor betaalbare prijs",
                    Price=15,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 3),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==2),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 2)
                },

                   new Item
                {
                    Id = 14,
                    Name ="Kids sneakers",
                    Img="/images/pexels-aman-jakhar-2048548.jpg",
                    ShortDescr="Exclusieve Tom&Jerry sneakers voor kids",
                    Price=80,
                     Category =
                        categoryRepository.GetCategories().
                            First(d => d.Id == 3),
                      Collections = collectionsRepository.GetCollections().First(col=>col.Id==3),
                      Property = propertyRepository.GetProperties().First(d => d.Id == 4)
                },

            };
        }
    }
}
