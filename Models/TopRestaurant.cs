using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProvoFood.Models
{
    public class TopRestaurant
    {
        public TopRestaurant(int RankParam)
        {
            Rank = RankParam;
        }
        [Required]
        public int Rank { get; }
        [Required]
        public string RestName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string RestAddress { get; set; }
        public string RestPhone { get; set; }
        public string RestSite { get; set; } = "Coming Soon";

        public static TopRestaurant[] GetRest()
        {
            TopRestaurant tr1 = new TopRestaurant(1)
            {
                RestName = "Guru's",
                FavDish = "Chicken Alfredo",
                RestAddress = "45 E Center St. Provo, UT",
                RestPhone = "801-375-4878",
                RestSite = "https://guruscafe.com/"
            };
            TopRestaurant tr2 = new TopRestaurant(2)
            {
                RestName = "Wild Ginger",
                FavDish = "All-You-Can-Eat Sushi",
                RestAddress = "366 N University Ave. Provo, UT",
                RestPhone = "801-691-1177",
                RestSite = "https://www.wildgingerut.com/"
            };
            TopRestaurant tr3 = new TopRestaurant(3)
            {
                RestName = "Papa Murhpy's",
                FavDish = "Chicken, Bacon, Arichoke Pizza on Thin Crust",
                RestAddress = "979 S University Ave. Suite 6, Provo, UT",
                RestPhone = "801-374-6500",
                RestSite = "https://locations.papamurphys.com/ut/provo/979-south-university-avenue?utm_source=organic&utm_medium=gmb&utm_campaign=yext"
            };
            TopRestaurant tr4 = new TopRestaurant(4)
            {
                RestName = "Texas Roadhouse",
                FavDish = "Chicken Critters, Mashed Potatoes, Ceaser Salad",
                RestAddress = "1265 State St. Orem, UT",
                RestPhone = "801-226-2742",
                RestSite = "https://www.texasroadhouse.com/locations/utah/orem"
            };
            TopRestaurant tr5 = new TopRestaurant(5)
            {
                RestName = "Don Juaqin Street Tacos",
                FavDish = "Asada Burrito",
                RestAddress = "150 W 1230 N St., Provo, UT",
                RestPhone = "801-400-2894",
                RestSite = "https://stdonjoaquin.com/"
            };

            return new TopRestaurant[] { tr1, tr2, tr3, tr4, tr5 };
        }
    }
}
