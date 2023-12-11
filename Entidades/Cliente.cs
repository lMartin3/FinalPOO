namespace Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string DniOCuit { get; set; } //DNI o CUIT 
        public CondicionFiscal CondicionFiscal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        public Cliente() { }
        
        public Cliente(string dni, CondicionFiscal condicionFiscal, string nombre, string direccion)
        {
            DniOCuit = dni;
            CondicionFiscal = condicionFiscal;
            Nombre = nombre;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}