using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjClase5
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        private string GetMarca()
        {
            return this.marca;
        }

        private float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: " + p.marca);
            sb.AppendLine("Codigo: " + p.codigoDeBarra);
            sb.AppendLine("Precio: " + p.precio);

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        /// <summary>
        /// Comparo dos objetos Producto a través de su Marca y Código de Barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si Marca y Código de Barras son iguales</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Comparo dos objetos Producto a través de su Marca y Código de Barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si Marca y Código de Barras son distintos</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Comparo un Producto con su Marca
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns>True si Marca son iguales</returns>
        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Comparo un Producto con su Marca
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns>True si Marca son distintos</returns>
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
