using System.Reflection;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XLog.Category.Application.Persistence;
using XLog.Category.Infrastructure.Persistence;
using XLog.Core.Persistence;
//using XLog.Category.Infrastructure.Dapr.Gateways;
//using XLog.Category.Infrastructure.Events;
using XLog.Infrastructure.Persistence;

namespace XLog.Category.Infrastructure.ServiceCollection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddHttpContextAccessor()
                .AddCustomDbContext(configuration.GetConnectionString("SqlConnection"))
                //.AddScoped<IDomainEventDispatcher, DomainEventDispatcher>()
                .AddTransient<IWardRepository, WardRepository>()
                .AddTransient<IPartnerRepository, PartnerRepository>()
                .AddTransient<IDistrictRepository, DistrictRepository>()
                .AddTransient<ICityRepository, CityRepository>()
                .AddTransient<ICountryRepository, CountryRepository>()
                .AddTransient<IPartnerTypeRepository, PartnerTypeRepository>()
                .AddTransient<IMerchandiseTypeRepository, MerchandiseTypeRepository>()
                .AddTransient<IExtraServiceRepository,ExtraServiceRepository>()
                .AddTransient<IPostalCodeRepository,PostalCodeRepository>()
                .AddTransient<IDeliveryStateRepository,DeliveryStateRepository>()
                .AddTransient<IUserGroupRepository,UserGroupRepository>()
                .AddTransient<IDeliveryMethodRepository,DeliveryMethodRepository>()
                .AddScoped(typeof(IRepository<>), typeof(EfRepository<>))
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                .AddCustomRequestValidation();
                //.AddCustomDapr()
                //.AddTransient<DaprStoresGateway>();

            return services;
        }
    }
}
