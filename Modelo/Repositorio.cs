using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public abstract class Repositorio<T>
    {
        protected List<T> elementos;
        public ReadOnlyCollection<T> ElementosAlmacenados => elementos.AsReadOnly();
        public virtual void AnadirElemento(T nuevoElemento)
        {
            if (!VerificarElemento(nuevoElemento))
            {
                return;
            }
            elementos.Add(nuevoElemento);
        }
        public virtual void EliminarElemento(T elementoAEliminar)
        {
            elementos.Remove(elementoAEliminar);
        }

        protected abstract bool VerificarElemento(T elementoAVerificar);
    }
}