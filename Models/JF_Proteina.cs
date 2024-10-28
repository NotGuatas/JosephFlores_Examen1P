using System.ComponentModel.DataAnnotations;

namespace JosephFlores_Examen1P.Models
{
    public class JF_Proteina
    {
        [Key]
        public int ProteinaId { set; get; }

        [Required(Erromessage)]
    }
}
