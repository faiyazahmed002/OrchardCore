using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace OrchardCore.Diagnostics.Elm
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddElm(options =>
            {
                options.Path = new Microsoft.AspNetCore.Http.PathString("/elm");
            });
        }

        public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            app.UseElmCapture();
            app.UseElmPage();
        }

        public override int Order => -100;
    }
}
