namespace DBFrutos2.Dominio
{
    public class Factura
    {
        public int Id { get; set; }
        public SolicitudPedidos pedido { get; set; }
        
    }
}