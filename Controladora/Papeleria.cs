using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras
{

    /// <summary>
    /// Clase responsable de instanciar todas las controladoras necesarias y mantener sus referencias.
    /// Se utiliza como singleton para no convertir cada controladora individual en un singleton
    /// </summary>
    public class Papeleria
    {
        private static Papeleria instancia;

        public static Papeleria Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Papeleria();
                }
                return instancia;
            }
        }
        

        public ControladoraClientes Clientes;
        public ControladoraProductos Productos;
        public ControladoraCategorias Categorias;
        public ControladoraOrdenesDeCompra Ordenes;
        public ControladoraProveedores Proveedores;
        public ControladoraVentas Ventas;


        private Papeleria()
        {
            this.Clientes = new ControladoraClientes();
            this.Productos = new ControladoraProductos();
            this.Categorias = new ControladoraCategorias();
            this.Ordenes = new ControladoraOrdenesDeCompra();
            this.Proveedores = new ControladoraProveedores();
            this.Ventas = new ControladoraVentas();
        }
        private void Inicio()
        {
            //AgregarMockDataConPercistenciaAsiQueOjoCuidado();
            //ventas.ElementoAgregadoEvent += ModificarStocksPorVenta;
        }

        private void AgregarMockDataConPercistenciaAsiQueOjoCuidado()
        {
            //Clientes dummies
            Cliente cliente1 = new Cliente("20221654868", CondicionFiscal.MONOTRIBUTISTA, "Juan Carlo Esposito", "Suipacha 2002");
            Cliente cliente2 = new Cliente("30168658578", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Pappenheimer S.A.", "Floripia 16");
            Cliente cliente3 = new Cliente("45508764", CondicionFiscal.CONSUMIDOR_FINAL, "Daniel Perino", "Mendoza 2335");
            Clientes.CrearCliente(cliente1);
            Clientes.CrearCliente(cliente2);
            Clientes.CrearCliente(cliente3);
            //Categorias Producto
            CategoriaProducto categoria1 = new CategoriaProducto(0, "Untensillos de Marcado", "Lápices, lapiceras y fibrones");
            CategoriaProducto categoria2 = new CategoriaProducto(1, "Resmas de papel", "Resmas de papel de diferentes tamaños");
            CategoriaProducto categoria3 = new CategoriaProducto(2, "Medición", "Productos que le sacamos a la vaca.");
            Categorias.CrearCategoria(categoria1);
            Categorias.CrearCategoria(categoria2);
            Categorias.CrearCategoria(categoria3);
            //Productos dummies
            Producto producto1 = new Producto(0, "Resma A4 500", "Resma de papel A4 500 hojas marca Libertad", 4000, 35, categoria2);
            Producto producto2 = new Producto(1, "Pack de fibrones Sharpie", "12 fibrones de colores varios", 6000, 15, categoria1);
            Producto producto3 = new Producto(2, "Pack de 20 lápices", "Lapices BIC B2", 6000, 20, categoria1);
            Producto producto4 = new Producto(3, "Paquete 20 lapiceras", "10 azules y 10 negras BIC", 3000, 20, categoria1);
            Producto producto5 = new Producto(4, "Regla metro", "Regla de 1m", 1500, 20, categoria3);
            Productos.CrearProducto(producto1);
            Productos.CrearProducto(producto2);
            Productos.CrearProducto(producto3);
            Productos.CrearProducto(producto4);
            Productos.CrearProducto(producto5);

            Proveedor proveedor1 = new Proveedor("30218686867", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Los Papeles Hermanos S.R.L.", "El Paso 512");
            Proveedor proveedor2 = new Proveedor("30154747476", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Papenberg S.A.", "Nuevo México 602");
            Proveedor proveedor3 = new Proveedor("30298545672", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Piedra de Sísifo S.R.L", "Turquía 1023");
            Proveedores.CrearProveedor(proveedor1);
            Proveedores.CrearProveedor(proveedor2);
            Proveedores.CrearProveedor(proveedor3);
        }
    }
}
