using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
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
            //Esto esta re mal creo no se estoy probando ostra cosa
            Inicio();
        }

        private void Inicio()
        {
            LlenarMockData();
        }

        public bool IntentarRegistrarVenta(Venta venta)
        {
            return Ventas.AgregarElemento(venta);
        }

        private void LlenarMockData()
        {
            //Clientes dummies
            Cliente cliente1 = new Cliente("45555515", CondicionFiscal.MONOTRIBUTISTA, "Juan Carlo Esposito", "Suipacha 2002");
            Cliente cliente2 = new Cliente("45555516", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Tarlos Tabón", "Floripia 16");
            Cliente cliente3 = new Cliente("45555517", CondicionFiscal.CONSUMIDOR_FINAL, "Damian Pepino", "Mendoza 2335");
            Clientes.AgregarElemento(cliente1);
            Clientes.AgregarElemento(cliente2);
            Clientes.AgregarElemento(cliente3);
            //Categorias Producto
            CategoriaProducto categoria1 = new CategoriaProducto(0, "Lacteo", "Productos que dió la vaca.");
            CategoriaProducto categoria2 = new CategoriaProducto(1, "Carne", "Productos que le sacamos a la vaca.");
            Categorias.AgregarElemento(categoria1);
            Categorias.AgregarElemento(categoria2);
            //Productos dummies
            Producto producto1 = new Producto(0, "Coca Cola 3L", "Una coca de tres litros", 1200, 20, categoria1);
            Producto producto2 = new Producto(1, "Milanesa", "1.5KG de milanesa lista para freir", 2000, 20, categoria2);
            Productos.AgregarElemento(producto1);
            Productos.AgregarElemento(producto2);

            Proveedor proveedor1 = new Proveedor("20112223337", CondicionFiscal.RESPONSABLE_INSCRIPTO, "Los Pollos Hermanos S.R.L.", "El Paso 512");
            Proveedor proveedor2 = new Proveedor("20445556668", CondicionFiscal.MONOTRIBUTISTA, "Heisenberg S.A.", "Nuevo México 602");
            Proveedores.AgregarElemento(proveedor1);
            Proveedores.AgregarElemento(proveedor2);
        }



    }
}
