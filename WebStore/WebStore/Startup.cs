using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebStore.DAL.Context;
using WebStore.Data;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Implementations;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration Configuration)
		{
			this.Configuration = Configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<WebStoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
			services.AddTransient<WebStoreContextInitializer>();

			services.AddSingleton<IEmployeesData, InMemoryEmployeesData>();
			//services.AddSingleton<IProductData, InMemoryProductData>();
			services.AddScoped<IProductData, SqlProductData>();
			services.AddScoped<ICartService, CookieCartService>();

			services.AddIdentity<User, IdentityRole>(opt =>
				{
					// конфигурация куки
				})
				.AddEntityFrameworkStores<WebStoreContext>()
				.AddDefaultTokenProviders();

			services.Configure<IdentityOptions>(cfg =>
			{
				cfg.Password.RequiredLength = 3;
				cfg.Password.RequireDigit = false;
				cfg.Password.RequireLowercase = false;
				cfg.Password.RequireUppercase = false;
				cfg.Password.RequireNonAlphanumeric = false;
				cfg.Password.RequiredUniqueChars = 3;

				cfg.Lockout.MaxFailedAccessAttempts = 10;
				cfg.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
				cfg.Lockout.AllowedForNewUsers = true;

				cfg.User.RequireUniqueEmail = false; // временно отключили
			});

			services.ConfigureApplicationCookie(cfg =>
			{
				cfg.Cookie.HttpOnly = true;
				cfg.Cookie.Expiration = TimeSpan.FromDays(150);
				cfg.Cookie.MaxAge = TimeSpan.FromDays(150);

				cfg.LoginPath = "/Account/Login";
				cfg.LogoutPath = "/Account/Logout";
				cfg.AccessDeniedPath = "/Account/AccessDenied";

				// нужно сменить номер сеанса после авторизации
				cfg.SlidingExpiration = true;
			});

			services.AddMvc(opt =>
			{
				//opt.Filters.Add<ActionFilter>();
				//opt.Conventions.Add(new TestConvention());
			});

			//AutoMapper.Mapper.Initialize(opt =>
			//{
			//	opt.CreateMap<Employee, Employee>(); //.ForMember(e=>e.FirstName, o => o.fir);
			//});

			services.AddAutoMapper(opt =>
			{
				opt.CreateMap<Employee, Employee>(); //.ForMember(e=>e.FirstName, o => o.fir);
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, WebStoreContextInitializer db)
		{
			db.InitializeAsync().Wait();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			}

			app.UseStaticFiles();
			app.UseDefaultFiles();

			//app.UseWelcomePage("/Welcome");

			app.UseAuthentication();

			//app.UseMvcWithDefaultRoute();
			app.UseMvc(route =>
			{
				route.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}"/*,
				defaults: new { 
				controller = "Home", action = "Index", id = (int?)null
				}*/);
			});
		}
	}
}
