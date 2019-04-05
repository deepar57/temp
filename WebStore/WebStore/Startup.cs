using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Infrastructure.Conventions;
using WebStore.Infrastructure.Filters;
using WebStore.Infrastructure.Implementations;
using WebStore.Infrastructure.Interfaces;

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
			services.AddSingleton<IEmployeesData, InMemoryEmployeesData>();


			services.AddMvc(opt => {
				//opt.Filters.Add<ActionFilter>();
				//opt.Conventions.Add(new TestConvention());
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();

			//app.UseWelcomePage("/Welcome");

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
