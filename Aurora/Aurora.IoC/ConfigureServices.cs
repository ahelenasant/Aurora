using MoonLight.Application.Interfaces;
using MoonLight.Application.Repositories;
using MoonLight.Application.UseCases.Customers;
using MoonLight.Application.UseCases.Customers.CustomersAddresses;
using MoonLight.Application.UseCases.Orders;
using MoonLight.Application.UseCases.Products;
using MoonLight.Domain.Entities;
using MoonLight.SqlServerData.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MoonLight.Infra.CrossCutting
{
    public static class ConfigureServices
	{
		private static IConfiguration _configuration;
		private static string? _connectionString { get; set; }

		public static void RegisterConfiguration(this IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionString = configuration.GetConnectionString("Default");
		}

		public static void RegisterServices(this IServiceCollection collection)
		{
			collection.AddTransient<IListUseCase<Product>, ListProductsUseCase>();
			collection.AddTransient<IRegisterUseCase<Product>, RegisterProductUseCase>();
			collection.AddTransient<IUpdateUseCase<Product>, UpdateProductUseCase>();

			//collection.AddTransient<IListUseCase<Customer>, ListCustomersUseCase>();
			collection.AddTransient<IRegisterUseCase<Customer>, RegisterCustomerUseCase>();
			collection.AddTransient<IUpdateUseCase<Customer>, UpdateCustomerUseCase>();

			//collection.AddTransient<IListUseCase<Customer>, ListCustomersUseCase>();
			collection.AddTransient<IRegisterUseCase<IEnumerable<CustomerAddress>>, RegisterCustomerAddressesUseCase>();
			collection.AddTransient<IUpdateUseCase<IEnumerable<CustomerAddress>>, UpdateCustomerAddressUseCase>();

			collection.AddTransient<IListUseCase<Order>, ListOrderUseCase>();
			collection.AddTransient<IRegisterUseCase<Order>, RegisterOrderUseCase>();

			collection.AddTransient<ICustomerRepository, CustomerRepository>();
			collection.AddTransient<ICustomerAddressRepository, CustomerAddressRepository>();
			collection.AddTransient<IOrderProductRepository, OrderProductRepository>();
			collection.AddTransient<IOrderRepository, OrderRepository>();
			collection.AddTransient<IProductRepository, ProductRepository>();
		}
	}
}
