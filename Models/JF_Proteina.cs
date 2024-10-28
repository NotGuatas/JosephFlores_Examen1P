using System.ComponentModel.DataAnnotations;

namespace JosephFlores_Examen1P.Models
{
    public class JF_Proteina
    {
        [Key]
        public int JFProteinaId {get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio ")]
        [StringLength(50,ErrorMessage = "El nombre no puede tener mas de 50 cáracteres")]
        public string? JFName  { get; set; }   

        [Required(ErrorMessage = "la fecha es obligatoria")]
        public DateTime? JFDate { get; set; }


        [Range(20.00, 120.00,ErrorMessage = "El precio debe estar entre los 20 dolares y 120 dolares ")]
        public decimal? JFPrecio { get; set; }    

        public bool JFWheyProtein { get; set; }

        public List<Promo>? JFProteins { get;set; }


    } 
}
