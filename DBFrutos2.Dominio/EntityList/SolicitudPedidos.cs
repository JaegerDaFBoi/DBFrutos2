namespace DBFrutos2.Dominio
{
    public class SolicitudPedidos
    {
        public int Id { get; set;}
        public Pedido Pedido { get; set; }
        public Inventario inventario { get; set; }
    }
}