using GoogleMapsComponents;
using GoogleMapsComponents.Maps;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazorGoogleMaps(new MapApiLoadOptions("API_KEY") {
  Version = "3",
  Libraries = "places,visualization,drawing,marker",
});

await builder.Build().RunAsync();
