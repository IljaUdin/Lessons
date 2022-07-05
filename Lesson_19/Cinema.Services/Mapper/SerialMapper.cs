using AutoMapper;
using Cinema.Entities;
using Cinema.Services.Dto;

namespace Cinema.Services.Mapper
{
    public class SerialMapper : IFilmMapper
    {
        public SerialMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Serial, SerialDto>().ReverseMap();
            });
            Mapper = config.CreateMapper();
        }

        /// <inheritdoc />
        public IConfigurationProvider ConfigurationProvider => Mapper.ConfigurationProvider;

        /// <summary>
        /// Объект маппера
        /// </summary>
        protected IMapper Mapper { get; set; }

        /// <inheritdoc />
        public T Map<T>(object source)
        {
            return Mapper.Map<T>(source);
        }

        /// <inheritdoc />
        public void Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            Mapper.Map(source, destination);
        }
    }
}
