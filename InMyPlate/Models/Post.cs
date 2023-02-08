using System;
using System.ComponentModel.DataAnnotations;

namespace InMyPlate.Models
{
	public class Post
	{

        public int Id { get; set; }

        [Required]
        public String? Title { get; set; }
        public String? Content { get; set; }
        public String? Image { get; set; }
        public int Likes { get; set; }
        public Boolean Save { get; set; }

        public int RestaurantId { get; set; }
        public int CityId { get; set; }

        public Restaurant? Restaurant { get; set; }
        public City? City { get; set; }
    }
}

