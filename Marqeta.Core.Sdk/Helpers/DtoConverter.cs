using AutoMapper;

namespace Marqeta.Core.Sdk.Helpers
{
    public static class DtoConverter
    {
        /// <summary>
        /// Converts a <inheritdoc cref="TInput"/> object into a <inheritdoc cref="TOutput"/> using Automapper
        /// </summary>
        /// <typeparam name="TInput">Input object type</typeparam>
        /// <typeparam name="TOutput">Output object type</typeparam>
        /// <param name="input">Input object</param>
        /// <returns>Output object as <inheritdoc cref="TOutput"/></returns>
        /// <example>
        ///     var body = DtoConverter.Convert<Auth_control_response, Auth_control_update_request>(authControl);
        /// </example>
        public static TOutput Convert<TInput, TOutput>(TInput input)
            where TInput : class
            where TOutput : class
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TInput, TOutput>();
            });
            var mapper = configuration.CreateMapper();
            return mapper.Map<TOutput>(input);
        }

        /// <summary>
        /// Converts a <inheritdoc cref="TInput"/> object into a <inheritdoc cref="TOutput"/> using Automapper
        /// </summary>
        /// <typeparam name="TInput">Input object type</typeparam>
        /// <typeparam name="TOutput">Output object type</typeparam>
        /// <param name="input">Input object</param>
        /// <param name="output">Output object</param>
        /// <example>
        ///     DtoConverter.Convert(authControl, out Auth_control_update_request body);
        /// </example>
        public static void Convert<TInput, TOutput>(TInput input, out TOutput output)
            where TInput : class
            where TOutput : class
        {
            output = Convert<TInput, TOutput>(input);
        }
    }
}
