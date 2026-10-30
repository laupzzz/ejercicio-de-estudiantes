namespace Library
{
    /// <summary>
    /// Representa el préstamo de un equipo a un estudiante.
    /// </summary>
    public class Prestamo
    {
        /// <summary>
        /// Obtiene el estudiante que solicitó el préstamo.
        /// </summary>
        public Estudiante Estudiante { get; private set; }

        /// <summary>
        /// Obtiene el equipo que fue prestado.
        /// </summary>
        public Equipo Equipo { get; private set; }

        /// <summary>
        /// Indica si el préstamo se encuentra activo actualmente.
        /// </summary>
        public bool Activo { get; private set; }

        /// <summary>
        /// Inicializa un préstamo e intenta reservar el equipo.
        /// </summary>
        /// <param name="estudiante">Estudiante solicitante.</param>
        /// <param name="equipo">Equipo solicitado.</param>
        public Prestamo(Estudiante estudiante, Equipo equipo)
        {
            this.Estudiante = estudiante;
            this.Equipo = equipo;

            if (this.Equipo.EstaDisponible())
            {
                this.Equipo.Prestar();
                this.Activo = true;
            }
        }

        /// <summary>
        /// Finaliza el préstamo y devuelve el equipo.
        /// </summary>
        public void Finalizar()
        {
            if (this.Activo)
            {
                this.Equipo.Devolver();
                this.Activo = false;
            }
        }
    }
}