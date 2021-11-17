using System.ComponentModel.DataAnnotations.Schema;

namespace DBFrutos2.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Valor { get; set; }
        public string Marca { get; set; }
    }
}