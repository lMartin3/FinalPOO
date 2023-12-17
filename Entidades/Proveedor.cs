namespace Entidades
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string Cuit { get; set; }
        public CondicionFiscal CondicionFiscal { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Proveedor(string cuit,
            CondicionFiscal condicionFiscal,
            string razonSocial,
            string direccion)
        {
            Cuit = cuit;
            CondicionFiscal = condicionFiscal;
            RazonSocial = razonSocial;
            Direccion = direccion;
        }

        public Proveedor() {
        }


        public override string ToString()
        {
            return RazonSocial;
        }
    }

}