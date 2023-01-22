namespace Omegan.Application.Utils
{
    /// <summary>
    /// Clase utilizada para contener la información que se enviará en un Response como resultado de una función AZURE FUNTION
    /// </summary>
    public class ResultResponse : BaseResponse
    {
        #region Definición de Mensajes estándares para el manejo del Result
        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_INSERT_OK = "La entidad fue creada satisfactoriamente dentro del sistema.";

        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_INSERT_FAILED = "La entidad '{0}' no pudo ser creada dentro del sistema.";

        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_DELETED = "La entidad '{0}' fue borrada satisfactoriamente dentro del sistema.";

        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_NOT_FOUND = "La entidad '{0}' no existe dentro del sistema.";


        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_LOGIN_FAILED = "Usuario o password incorrectos";


        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_NOT_FOUND_ID = "Ingerese un id";
        #endregion

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="resource">Saved user.</param>
        /// <returns>Response.</returns>
        public ResultResponse(object resource) : base(resource)
        { }

        /// <summary>
        /// Creates a fail response.
        /// </summary>
        /// <param name="ex">Exception.</param>
        /// <returns>Response.</returns>
        public ResultResponse(Exception ex) : base(ex)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ResultResponse(string message) : base(message)
        { }


        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_USER_FAILED_EMAIL = "El correo o documento no pudo ser creada dentro del sistema por que  ya existe.";


        /// <summary>
        /// Mensaje adición correnta de la entidad
        /// </summary>
        public const string ENTITY_USER_CLIENT = "El usuario no pudo ser creada dentro del sistema por que  ya existe.";
        /// <summary>
        /// 
        /// </summary>
        public const string ENTITY_INSERT_SUCCESSFUL = "Datos registrados con éxito";


        /// <summary>
        /// 
        /// </summary>
        public const string ENTITY_ERROR_DATE = "La fecha de expedición es requerida.";

        /// <summary>
        /// 
        /// </summary>
        public const string ENTITY_GET = "Se realizo la consulta correctamente";

        /// <summary>
        /// 
        /// </summary>
        public const string ENTITY_GET_ERROR = "Error al realizar la consulta";

    }
}
