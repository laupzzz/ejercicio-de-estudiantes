namespace Library
{
    /// <summary>
    /// Representa un equipo que puede ser prestado.
    /// </summary>
    public class Equipo : IPrestable
    {
        /// <summary>
        /// Obtiene el código del equipo.
        /// </summary>
        public string Codigo { get; private set; }
        /// <summary>
        /// Indica si el equipo está disponible.
        /// </summary>
        public bool Disponible { get; private set; }
        /// <summary>
        /// Inicializa un nuevo equipo.
        /// </summary>
        /// <param name="codigo">El código identificador del equipo.</param>
        public Equipo(string codigo)
        {
            this.Codigo = codigo;
            this.Disponible = true;
        }
        /// <summary>
        /// Indica si el equipo puede ser prestado.
        /// </summary>
        /// <returns>True si está disponible.</returns>
        public bool EstaDisponible()
        {
            return this.Disponible;
        }
        /// <summary>
        /// Marca el equipo como prestado (no disponible).
        /// </summary>
        public void Prestar()
        {
            this.Disponible = false;
        }
        /// <summary>
        /// Marca el equipo como devuelto (disponible).
        /// </summary>
        public void Devolver()
        {
            this.Disponible = true;
        }
    }
}