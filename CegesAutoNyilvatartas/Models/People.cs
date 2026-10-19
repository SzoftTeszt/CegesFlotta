using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegesAutoNyilvatartas.Models
{
    public class People
    {
        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Class { get; set; } = "";

        public List<Auto> Autok { get; set; } = new();


        public override string? ToString()
        {
            return $"{Name} - {Class}";
        }
    }
}
