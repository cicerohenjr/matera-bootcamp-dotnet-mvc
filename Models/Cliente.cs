using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootCampDev.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Display(Name = "Biografia/Observações")]
        public string Biografia { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        // Relacionamento: Um cliente pode ter vários pedidos
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
