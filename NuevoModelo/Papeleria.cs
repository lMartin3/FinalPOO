using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoModelo
{
    public class Papeleria
    {
        private RepoClientes clientes = new RepoClientes();
        private RepoProductos productos = new RepoProductos();
        private RepoProveedores proveedores = new RepoProveedores();
        private RepoVentas ventas = new RepoVentas();
        private RepoOrdenes ordenes = new RepoOrdenes();
        private RepoCategorias categorias = new RepoCategorias();

        public RepoClientes Clientes { get => clientes; private set => clientes = value; }
        public RepoProductos Productos { get => productos; private set => productos = value; }
        public RepoProveedores Proveedores { get => proveedores; private set => proveedores = value; }
        public RepoVentas Ventas { get => ventas; private set => ventas = value; }
        public RepoOrdenes Ordenes { get => ordenes; private set => ordenes = value; }
        public RepoCategorias Categorias { get => categorias; private set => categorias = value; }

        public Papeleria()
        {
            Inicio();
        }

        private void Inicio()
        {
            LlenarMockData();
            ventas.ElementoAgregadoEvent += ModificarStocksPorVenta;
        }

        public void ModificarStocksPorVenta(Venta venta)
        {
            foreach (ItemProducto item in venta.Items)
            {
                float stockVendido = item.Cantidad;
                Producto productoVendido = item.Producto;
                productoVendido.SubstraerStock(item.Cantidad);
            }
        }

        public bool IntentarRegistrarVenta(Venta venta)
        {
            return Ventas.AgregarElemento(venta);
        }

        private void LlenarMockData()
        {
            //Clientes dummies
            Cliente cliente1 = new Cliente("20221654868", CondicionFiscal.MONOTRIBUTISTA, "Juan Carlo Esposito", "Suipacha 2002");
            Cliente cliente2 = new Cliente("30168658578", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Pappenheimer S.A.", "Floripia 16");
            Cliente cliente3 = new Cliente("45508764", CondicionFiscal.CONSUMIDOR_FINAL, "Daniel Perino", "Mendoza 2335");
            Clientes.AgregarElemento(cliente1);
            Clientes.AgregarElemento(cliente2);
            Clientes.AgregarElemento(cliente3);
            //Categorias Producto
            CategoriaProducto categoria1 = new CategoriaProducto(0, "Untensillos de Marcado", "Lápices, lapiceras y fibrones");
            CategoriaProducto categoria2 = new CategoriaProducto(1, "Resmas de papel", "Resmas de papel de diferentes tamaños");
            CategoriaProducto categoria3 = new CategoriaProducto(2, "Medición", "Productos que le sacamos a la vaca.");
            Categorias.AgregarElemento(categoria1);
            Categorias.AgregarElemento(categoria2);
            Categorias.AgregarElemento(categoria3);
            //Productos dummies
            Producto producto1 = new Producto(0, "Resma A4 500", "Resma de papel A4 500 hojas marca Libertad", 4000, 35, categoria2);
            Producto producto2 = new Producto(1, "Pack de fibrones Sharpie", "12 fibrones de colores varios", 6000, 15, categoria1);
            Producto producto3 = new Producto(2, "Pack de 20 lápices", "Lapices BIC B2", 6000, 20, categoria1);
            Producto producto4 = new Producto(3, "Paquete 20 lapiceras", "10 azules y 10 negras BIC", 3000, 20, categoria1);
            Producto producto5 = new Producto(4, "Regla metro", "Regla de 1m", 1500, 20, categoria3);
            Productos.AgregarElemento(producto1);
            Productos.AgregarElemento(producto2);
            Productos.AgregarElemento(producto3);
            Productos.AgregarElemento(producto4);
            Productos.AgregarElemento(producto5);

            Proveedor proveedor1 = new Proveedor("30218686867", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Los Papeles Hermanos S.R.L.", "El Paso 512");
            Proveedor proveedor2 = new Proveedor("30154747476", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Papenberg S.A.", "Nuevo México 602");
            Proveedor proveedor3 = new Proveedor("30298545672", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Piedra de Sísifo S.R.L", "Turquía 1023");
            Proveedores.AgregarElemento(proveedor1);
            Proveedores.AgregarElemento(proveedor2);
            Proveedores.AgregarElemento(proveedor3);
        }



    }
}
