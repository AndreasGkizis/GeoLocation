using Microsoft.Extensions.DependencyInjection;

namespace GeolocationFinder
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // LITTLE DI CONTAINER 

            ServiceProvider? serviceProvider = new ServiceCollection()
            .AddSingleton<IClientFactory, ClientFactory>()
            .AddTransient<CountryFinder>()
            .BuildServiceProvider();

        
            CountryFinder countryFinder = serviceProvider.GetRequiredService<CountryFinder>();

            string[] ipAddressArray = {
                                    "74.159.99.118",
                                    "103.147.76.223",
                                    "148.78.90.20",
                                    "132.13.183.75",
                                    "89.42.248.72",
                                    "127.93.187.230",
                                    "214.174.75.248",
                                    "84.132.181.8",
                                    "22.36.109.198",
                                    "3.63.115.177"
                                };

            foreach (var address in ipAddressArray)
            {
                await countryFinder.MakeHttpCallAsync(address);
                await countryFinder.MakeHttpsCallAsync(address);
                await countryFinder.MakeHttpCallAsyncWithDecimal(address);
                await countryFinder.MakeHttpsCallAsyncWithDecimal(address);
            }
        }
    }
}