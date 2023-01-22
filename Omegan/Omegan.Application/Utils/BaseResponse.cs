namespace Omegan.Application.Utils
{
    /// <summary>
    /// Clase abstacta  que define los elementos básicos para el manejo de un Response en las funciones AZURE FUNCTONS
    /// </summary>
    public abstract class BaseResponse
    {
        /// <summary>
        /// Indicador de Exito o fracaso de la acción.
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Objeto de Error que se report en el mensaje de respuesta.
        /// </summary>
        public Exception? Error { get; private set; }
        /// <summary>
        /// Objeto que contiene la respuesta de la respectiva acción
        /// </summary>
        public object? Result { get; private set; }
        /// <summary>
        /// Mensaje propio de la respuesta.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Método constructor de la clase.
        /// </summary>
        /// <param name="resource">objeto que se desea pasar como parte del mensaje Response.</param>
        protected BaseResponse(object resource)
        {
            Success = true;
            Message = string.Empty;
            Result = resource;
            Error = default;
        }

        /// <summary>
        /// Método constructor de la clase.
        /// </summary>
        /// <param name="ex">Excepción a ser controlada.</param>
        protected BaseResponse(Exception ex)
        {
            Success = false;
            Message = string.Empty;
            Result = default;
            Error = ex;
        }

        /// <summary>
        /// Método constructor de la clase.
        /// </summary>
        /// <param name="message">Mensaje que se desea enviar dentro del Response</param>
        protected BaseResponse(string message)
        {
            Success = false;
            Message = message;
            Result = default;
            Error = default;
        }
    }
}
