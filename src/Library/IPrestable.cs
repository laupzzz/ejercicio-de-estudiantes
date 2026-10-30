namespace Library
{
    /// <summary>
    /// Define el contrato que debe cumplir un elemento prestable.
    /// </summary>
    public interface IPrestable
    {
        /// <summary>
        /// Indica si el elemento está disponible.
        /// </summary>
        /// <returns>True si puede prestarse.</returns>
        bool EstaDisponible();

        /// <summary>
        /// Marca el elemento como prestado.
        /// </summary>
        void Prestar();

        /// <summary>
        /// Marca el elemento como disponible nuevamente.
        /// </summary>
        void Devolver();
    }
}