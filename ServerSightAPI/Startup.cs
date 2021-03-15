using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServerSightAPI.Configurations;
using ServerSightAPI.Configurations.Services;
using ServerSightAPI.Middleware;
using ServerSightAPI.Repository;
using ServerSightAPI.Services;

namespace ServerSightAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigurePostgreDatabase(Configuration);

            services.AddAuthentication();
            services.AddAuthorization();
            services.ConfigureIdentity();
            
            services.AddControllers();
            
            services.ConfigureCorsHeaders();
            services.AddHttpContextAccessor();
            
            services.ConfigureJwt(Configuration);

            // provides an instances when the application aks one to inject
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthManager, AuthManager>();
            
            services.AddAutoMapper(typeof(MapperInitializer));
            
            services.ConfigureSwagger();
            
            services.AddMemoryCache();
            services.ConfigureModelStateHandler();
            
            services.AddControllers().AddNewtonsoftJson(op => 
                op.SerializerSettings.ReferenceLoopHandling = 
                    Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // in production you should something like nginx or caddy
                app.UseConfiguredStaticFiles(env);
            }

            app.UseCors("CorsPolicy");

            app.UseSwagger();
            app.UseSwaggerUi();
            
            app.UseHttpsRedirection();
            app.ConfigureExceptionHandler();

            app.UseRouting();
            
            app.UseResponseCaching();
            
            // for nginx reverse proxy header passing.
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}