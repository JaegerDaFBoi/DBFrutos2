using System;
using System.Collections.Generic;


namespace DBFrutos2.Dominio
{
    public class Pedido
    {
        public int Id { get; set;}
        public int Cantidad { get; set; }
        public float ValorVenta { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Empresa_Envio { get; set; }
        public string Metodo_Pago { get; set; }
        public float Valor_Declarado { get; set; }
        public string Observacion { get; set; }
    }
}