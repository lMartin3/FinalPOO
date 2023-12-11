namespace Entidades
{
    public class OrdenCompra
    {
        public int OrdenCompraId { get; set; }
        public string NroOrden { get; private set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; private set; }

        public DateOnly Fecha { get; set; }
        public List<ItemProducto> Items { get; private set; } = new List<ItemProducto>();


        public OrdenCompra(string nroOrden,
            Proveedor proveedor,
            List<ItemProducto> listaItems)
        {
            NroOrden = nroOrden;
            Proveedor = proveedor;
            Items = listaItems;
        }

        public int CantidadItems
        {
            get => Items.Count;
        }

        public float Total
        {
            get => Items.Select(i=>i.Subtotal).Sum();
            
        }

        //TODO Arreglar esto
        public string ResumenItems => "FIXME";
    } 
    
}