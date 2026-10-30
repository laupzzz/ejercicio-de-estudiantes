namespace Library
{
    /// <summary>
    /// Representa un estudiante que puede solicitar equipos en préstamo.
    /// </summary>
    public class Estudiante
    {
        /// <summary>
        /// Obtiene el nombre del estudiante.
        /// </summary>
        public string Nombre { get; private set; }

        /// <summary>
        /// Obtiene el documento del estudiante.
        /// </summary>
        public string Documento { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de Estudiante.
        /// </summary>
        /// <param name="nombre">Nombre completo.</param>
        /// <param name="documento">Documento.</param>
        public Estudiante(string nombre, string documento)
        {
            this.Nombre = nombre;
            this.Documento = documento;
        }

        /// <summary>
        /// Devuelve una descripción textual.
        /// </summary>
        /// <returns>Nombre y documento.</returns>
        public string ObtenerDescripcion()
        {
            return $"{this.Nombre} - {this.Documento}";
        }
    }
}