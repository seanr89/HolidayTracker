

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Employee.API.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class DependenciesExtensions
    {
        /// <summary>
        /// Handle the management for API Dependency Injection
        /// </summary>
        /// <param name="services">startup service collection</param>
        /// <returns>services returned with injected dependencies</returns>
        public static void ConfigureDependencies(this IServiceCollection services)
        {
        }
    }
}