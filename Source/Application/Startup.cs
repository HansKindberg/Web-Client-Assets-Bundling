using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
	public class Startup
	{
		#region Constructors

		public Startup(IConfiguration configuration, IWebHostEnvironment environment)
		{
			this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
			this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
		}

		#endregion

		#region Properties

		public virtual IConfiguration Configuration { get; }
		public virtual IWebHostEnvironment Environment { get; }

		#endregion

		#region Methods

		public virtual void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment env)
		{
			applicationBuilder
				.UseDeveloperExceptionPage()
				.UseStaticFiles()
				.UseRouting()
				.UseAuthorization()
				.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
		}

		public virtual void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
		}

		#endregion
	}
}