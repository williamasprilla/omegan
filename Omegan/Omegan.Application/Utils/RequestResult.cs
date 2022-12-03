namespace Omegan.Application.Utils
{
    public class RequestResult<T>
    {
        /// <summary>
        /// Objeto que se devuelve
        /// </summary>
        public T ObjectEmbebed { get; set; }

        /// <summary>
        /// Permite saber si se realizó correctamente el proceso
        /// </summary>
        public bool IsSuccesfull { get; set; }

        /// <summary>
        /// Mensaje que se retorna ya sea de error o correcto
        /// </summary>
        public string Message { get; set; }
    }
}
