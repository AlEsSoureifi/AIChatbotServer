using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AxelosChatBotFinal.Models
{
    public class PDFFile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public List<SeparatedText> Texts { get; set; }
    }
}
