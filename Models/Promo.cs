using System.ComponentModel.DataAnnotations;

namespace JosephFlores_Examen1P.Models
{
    public class Promo
    {
        public int PromoId { get; set; }

        public string descripcion {  get; set; }

        [Required(ErrorMessage = "la fecha es obligatoria")]
        public DateTime? Date { get; set; }

        public int ProteinaID {  get; set; }    
        public JF_Proteina? Proteina { get; set; }   

    }
}
