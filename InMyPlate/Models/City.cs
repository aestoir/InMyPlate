using System;
using System.ComponentModel.DataAnnotations;

namespace InMyPlate.Models
{
	public class City
	{
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public String? Name { get; set; }
        public String? Image { get; set; }
        public List<Post>? Posts { get; set; }
        public List<Restaurant>? Restaurants { get; set; }
    }
}

