using System.ComponentModel.DataAnnotations;

namespace ASPnet_API_Uppgifter1.Models
{
    public class CD
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Artist { get; set; }

        

    }
}
