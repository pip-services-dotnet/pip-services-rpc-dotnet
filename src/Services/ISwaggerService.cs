
namespace PipServices3.Rpc.Services
{
    /// <summary>
    /// Interface to perform Swagger registrations.
    /// </summary>
    public interface ISwaggerService
    {
        /// <summary>
        /// Perform required Swagger registration steps.
        /// </summary>
        void RegisterOpenApiSpec(string baseRoute, string swaggerRoute);
    }
}