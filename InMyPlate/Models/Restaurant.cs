using System;
using System.ComponentModel.DataAnnotations;

namespace InMyPlate.Models
{
	public class Restaurant
	{

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public String? Name { get; set; }
        public String? Image { get; set; }
        public List<Post>? Posts { get; set; }
        public int Likes { get; set; }
        public Boolean Save { get; set; }

        public int CityId { get; set; }

        public City? City { get; set; }
    }
}

