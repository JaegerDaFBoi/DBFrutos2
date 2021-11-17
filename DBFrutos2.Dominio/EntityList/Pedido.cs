using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBFrutos2.Dominio
{
    public class Pedido
    {
        public int Id { get; set;}
        public int Cantidad { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Valor { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Empresa_Envio { get; set; }
        public string Metodo_Pago { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Valor_Declarado { get; set; }
        public string Observacion { get; set; }
    }
}