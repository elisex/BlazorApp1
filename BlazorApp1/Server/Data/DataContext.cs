﻿using BlazorApp1.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.EditionId });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name ="Standard cars", Url="standard", Icon="battery-full" }
                , new Category { Id = 2, Name= "Cars film", Url="cars", Icon="camera-slr" }
                , new Category { Id = 3, Name= "Cars from movies", Url="movies", Icon="aperture" }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                CategoryId =1,
                Title = "Lotus Elise",
                Description = "The Lotus Elise is available with a 1.8-litre, four-cylinder engine in two states of tune. The Sport 220 offers 217bhp, while the Cup 250 makes a stronger case for itself with 243bhp. Both have identical torque figures at 184lb ft, but the Cup 250 develops its pulling power lower down the rev range. Acceleration from 0-62mph takes 4.6 seconds and 4.3 seconds respectively, with the pair moving on to ample top speeds of 145mph and 150mph via the six-speed manual transmission. The Elise is also one of the few cars on the road with no power steering, which results in a fantastic accuracy and amount of feel through the wheel.",
                Image = "https://www.topgear.com/sites/default/files/cars-car/carousel/2019/07/751a3478_0.jpg?w=892&h=502",
                DateCreated = new DateTime(2023, 02, 27)
            },
            new Product
            {
                Id = 2,
                CategoryId = 2,
                Title = "Lightning McQueen",
                Description = "Lightning McQueen is a 2006 Custom-Built Piston Cup Racing stock car, with a top speed of 198mph, and accelerattion of 0-60 in 4 seconds. Lightning's body is built from 24-gauge Cold-rolled Sheet Steel, and chassis has a high strength tubular frame.",
                Image = "https://images.squarespace-cdn.com/content/v1/5ae237043917eef6a6aeebce/1524780584779-3K5X1Q384A7QF4PA2UU4/IMG_0959.JPG?format=1000w",
                DateCreated = new DateTime(2023, 02, 27)
            },
            new Product
            {
                Id = 3,
                CategoryId = 2,
                Title = "911 Sally Special",
                Description = "Based on a 2002 Porsche 911 Carrera GTS, the most distinctive feature of the car is its “Sally Blue Metallic” exterior paint color, made exclusively for the one-of-one vehicle. Additional exclusive features of the Sally Special include a “Carrera” designation on the vehicle’s rear and a set of custom five-spoke 911 Turbo wheels inspired by those of the vehicle’s namesake.",
                Image= "https://media.autoexpress.co.uk/image/private/s--8Hv5ZbZt--/v1661262351/evo/2022/08/Porsche%20911%20Sally%20Carrera%20Special%20Edition%20high%20res-2.jpg",
                DateCreated = new DateTime(2023, 02, 27)
            },
            new Product
            {
                Id = 4,
                CategoryId = 3,
                Title = "The Mystery Machine",
                Description = "The Chevrolet Van was a series of vans introduced for the 1964 model year. The Chevrolet Van succeeded the Chevrolet Greenbrier, and was launched with the G-10 half-ton variant. A 'Sportvan' was later added to the range that included integrated windows. The first two generations of van were built with a front mid engine layout, but from 1971 onwards, the engine was a front mounted unit. A wide range of engines have been fitted to the Chevrolet Van, including inline four, V6, and V8 units. The Van was configurable for a variety of uses, including passenger, cargo, and bus versions. Production of the Chevrolet Van ended in 1995, and the model was replaced by the Chevrolet Express.",
                Image= "https://i.ytimg.com/vi/ArKckzLPM0M/maxresdefault.jpg",
                DateCreated = new DateTime(2023, 02, 27)
            });

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id= 1, Name="Default" },
                    new Edition { Id= 2,Name="Buy now"},
                    new Edition { Id= 3, Name="Finance" }
                );
            modelBuilder.Entity<ProductVariant>().HasData(
                    new ProductVariant
                    {
                        ProductId = 1,
                        EditionId = 2,
                        Price = 97990m,
                        OriginalPrice = 99000m,
                        Quantity = 40
                    },
                    new ProductVariant
                    {
                        ProductId = 1,
                        EditionId = 3,
                        Price = 109990m,
                        OriginalPrice = 129990m,
                        Quantity = 45
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        EditionId = 2,
                        Price = 81700m,
                        OriginalPrice = 81700m,
                        Quantity = 150
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        EditionId = 3,
                        Price = 87110m,
                        OriginalPrice = 95000m,
                        Quantity = 155
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        EditionId = 2,
                        Price = 3100000m,
                        OriginalPrice = 3100000m,
                        Quantity = 90
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        EditionId = 3,
                        Price = 3600000m,
                        OriginalPrice = 3600000m,
                        Quantity = 95
                    },
                    new ProductVariant
                    {
                        ProductId = 4,
                        EditionId = 2,
                        Price = 27.99m,
                        OriginalPrice = 30.99m,
                        Quantity = 200
                    },
                    new ProductVariant
                    {
                        ProductId = 4,
                        EditionId = 3,
                        Price = 34.99m,
                        OriginalPrice = 40.99m,
                        Quantity = 205
                    }
                );
        }
    }
}