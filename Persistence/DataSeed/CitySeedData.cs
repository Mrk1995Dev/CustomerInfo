﻿using Domain.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DataSeed
{
    public static class CitySeedData
    {
        public static List<City> GetCities()
        {
            return new List<City>()
            {
                 new City {Id = 1, Title = "آذربایجان شرقی"},
                 new City { Id = 2, Title = "آذربایجان غربی" },
                 new City { Id = 3, Title = "اردبیل" },
                 new City { Id = 4, Title = "اصفهان" },
                 new City { Id = 5, Title = "البرز" },
                 new City { Id = 6, Title = "ایلام" },
                 new City { Id = 7, Title = "بوشهر" },
                 new City { Id = 8, Title = "تهران" },
                 new City { Id = 9, Title = "چهارمحال و بختیاری" },
                 new City { Id = 10, Title = "خراسان جنوبی" },
                 new City { Id = 11, Title = "خراسان رضوی" },
                 new City { Id = 12, Title = "خراسان شمالی" },
                 new City { Id = 13, Title = "خوزستان" },
                 new City { Id = 14, Title = "زنجان" },
                 new City { Id = 15, Title = "سمنان" },
                 new City { Id = 16, Title = "سیستان و بلوچستان" },
                 new City { Id = 17, Title = "فارس" },
                 new City { Id = 18, Title = "قزوین" },
                 new City { Id = 19, Title = "قم" },
                 new City { Id = 20, Title = "کردستان" },
                 new City { Id = 21, Title = "کرمان" },
                 new City { Id = 22, Title = "کرمانشاه" },
                 new City { Id = 23, Title = "کهگیلویه و بویراحمد" },
                 new City { Id = 24, Title = "گلستان" },
                 new City { Id = 25, Title = "گیلان" },
                 new City { Id = 26, Title = "لرستان" },
                 new City { Id = 27, Title = "مازندران" },
                 new City { Id = 28, Title = "مرکزی" },
                 new City { Id = 29, Title = "هرمزگان" },
                 new City { Id = 30, Title = "همدان" },
                 new City { Id = 31, Title = "یزد" },
                 new City { Id = 32, Title = "کیش" }
            };
        }
    }
}
