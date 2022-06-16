using System.Collections.Generic;
using System.Linq;
using API.Entity;

namespace API.Data
{
    public static class DbIntializer
    {
        public static void Intialize(DataContext context)
        {
            if(context.BloodProviders.Any()) return;

            var providers = new List<BloodProvider>
            {
                new BloodProvider{
                    Name = "Dinh Minh Duc",
                    Address = "180 Trieu Khuc, Ha Dong, Ha Noi",
                    City = "Ha Noi",
                    Sex = "Nam",
                    Weight = "70kg",
                    Birth = "25/11/2001",
                    BloodType = "A",
                    Phone = "09999999",
                    Email = "duc@gmail.com"
                },
                new BloodProvider{
                    Name = "La Gia Huy",
                    Address = "122 Tran Quoc Nghien, Hon Gai, Quang Ninh",
                    City = "Ha Long",
                    Sex = "Nam",
                    Weight = "69kg",
                    Birth = "16/7/2001",
                    BloodType = "B",
                    Phone = "088888888",
                    Email = "huy@gmail.com"
                },
                new BloodProvider{
                    Name = "Pham Quoc Duy",
                    Address = "72 Le Thanh Ton, Quan 1",
                    City = "Ho Chi Minh",
                    Sex = "Nam",
                    Weight = "80kg",
                    Birth = "1/1/2001",
                    BloodType = "O",
                    Phone = "077777777",
                    Email = "duy@gmail.com"
                },
                new BloodProvider{
                    Name = "Nguyen Duc Tam",
                    Address = "16 Thanh Luong, Quan Thanh Khe, Da Nang",
                    City = "Da Nang",
                    Sex = "Nam",
                    Weight = "100kg",
                    Birth = "2/2/2001",
                    BloodType = "AB",
                    Phone = "0955555555",
                    Email = "tam@gmail.com"
                },
                new BloodProvider{
                    Name = "Nguyen Thanh Mai",
                    Address = "18 Tran Phu, Thai Binh",
                    City = "Thai Binh",
                    Sex = "Nu",
                    Weight = "51kg",
                    Birth = "23/12/2001",
                    BloodType = "A",
                    Phone = "0333333333",
                    Email = "mai@gmail.com"
                },
                new BloodProvider{
                    Name = "Hoang Thi Lan",
                    Address = "lang Dao Tu, Song Ho, Thuan Thanh",
                    City = "Bac Ninh",
                    Sex = "Nu",
                    Weight = "44kg",
                    Birth = "21/12/2001",
                    BloodType = "A",
                    Phone = "0111111111",
                    Email = "lan@gmail.com"
                }

            };

            foreach (var provider in providers){
                context.BloodProviders.Add(provider);
            }

            context.SaveChanges();
        }
    }
}