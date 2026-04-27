using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootCampDev.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime DataPedido { get; set; } = DateTime.Now;

        // Chave Estrangeira para Cliente
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
    }
}
