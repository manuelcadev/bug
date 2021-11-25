using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 50, MinimumLength= 3, ErrorMessage ="La logitud del campo {0} debe estar entre {2} y {1}" )]
        [Required(ErrorMessage ="El campo {0}} es requerido")]     
        [Display(Name ="Nombre del tipo cuenta")]   
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }
    }
}