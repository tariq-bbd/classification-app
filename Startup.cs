using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ClassificationApp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity;

namespace ClassificationApp
{
    public class Startup
    {
        private string _connString;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = Configuration["DB-DataSource"];
            builder.InitialCatalog = Configuration["DB-InitialCatalog"];
            builder.UserID = Configuration["DB-UserID"];
            builder.Password = Configuration["DB-Password"];
            _connString = builder.ConnectionString;

            services.AddDbContext<AuthDbContext>(options =>
                options.UseSqlServer(_connString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthentication()
            .AddGoogle(
                options =>
                {
                    options.ClientId = Configuration["Google-Auth-ClientID"];
                    options.ClientSecret = Configuration["Google-Auth-ClientSecret"];
                    options.CallbackPath ="auth/google-signin";
                }
            ).AddCookie();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
