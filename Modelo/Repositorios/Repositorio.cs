using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;

namespace Modelo
{
    /// <summary>
    /// Esta clase es responsable de almacenar elementos de cierto tipo
    /// y controlar su acceso
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a almacenar</typeparam>
    public abstract class Repositorio<T>
    {
        public delegate void ElementoAgregadoEventHandler(T elemento);
        public event ElementoAgregadoEventHandler ElementoAgregadoEvent;

        protected List<T> elementos = new List<T>();
        public ReadOnlyCollection<T> ElementosAlmacenados => elementos.AsReadOnly();
        
        public virtual bool AgregarElemento(T nuevoElemento)
        {
            if (!PuedeAgregarElemento(nuevoElemento))
            {
                return false;
            }
            elementos.Add(nuevoElemento);
            ElementoAgregadoEvent?.Invoke(nuevoElemento);
            return true;
        }

        public virtual void EliminarElemento(T elementoAEliminar)
        {
            elementos.Remove(elementoAEliminar);
        }

        /// <summary>
        /// Método para determinar si un elemento puede ser almacenado
        /// en el repositorio.<br/>
        /// La implementación depende de cada subclase de <see cref="Repositorio{T}">Repositorio</see>
        /// </summary>
        /// <param name="elementoAVerificar">Nuevo elemento que se desea almacenar</param>
        /// <returns><see cref="bool">bool</see>: si el elemento cumple los requisitos para ser agregado</returns>
        protected abstract bool PuedeAgregarElemento(T elementoAVerificar);
    }
}