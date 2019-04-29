using IrlFF.Data;
using IrlFF.Data.Repositories;
using IrlFF.Data.Services;
using IrlFF.Web.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Text;

namespace IrlFF.Web
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
            #region CORS
            //services.AddCors();
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials().Build();
                });
            });
            #endregion

            #region AppSettings
            // Configure AppSettings and add to DI
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            #endregion

            #region JWT
            // Configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            // Add Jwt Authentication Service
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            #endregion

            #region Add Transient DI
            services.AddTransient<IPlayerService, PlayerService>();
                services.AddTransient<ITeamService, TeamService>();
                services.AddTransient<IClubService, ClubService>();
                services.AddTransient<ITeamPlayerService, TeamPlayerService>();
                services.AddTransient<IFixtureService, FixtureService>();
                services.AddTransient<IUserService, UserService>();
            #endregion

            // Use SQL Database if in Azure, otherwise, Use local SSMS
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            {
                services.AddDbContext<FFDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("MyDbConnection")));
            }
            else
            {
                //services.AddDbContext<FFDbContext>(options =>
                //        options.UseSqlServer(@"Server=tcp:irlff.database.windows.net,1433;Initial Catalog=IrlFFDb;Persist Security Info=False;User ID=s6irladmin;Password=5Maxin2e;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=200;"));
                services.AddDbContext<FFDbContext>(options =>
                       options.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFF; Trusted_Connection = True; ConnectRetryCount = 0;"));
            }

            // Automatically perform database migration
            //services.BuildServiceProvider().GetService<FFDbContext>().Database.Migrate();

            //var context = services.BuildServiceProvider().GetRequiredService<FFDbContext>();
            //context.Database.EnsureCreated();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => { options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // seeder recreates and seeds database on each execution
                new DataSeeder().Seed();
            }
            if (env.IsProduction() || env.IsStaging() || env.IsEnvironment("Staging_2"))
            {
                using (var scope = provider.CreateScope())
                {
                    // now you can pretend you're inside of a normal Request Scope (somewhat)
                    var dbContext = scope.ServiceProvider.GetRequiredService<FFDbContext>();

                    dbContext.Database.Migrate();
                }

                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCookiePolicy();

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
