using System.IO;
using Microsoft.AspNetCore.Hosting;
using Wbc.Domain.Repositories;
using Wbc.Repositories;

namespace Wbc.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var repo = new RepositoryFactory();
			ICompanyRepository userRepo = repo.GetCompanyRepository();
			//userRepo.AddAsync(new Domain.Models.User
			//{
			//	UserName = "hello"
			//}).Wait();
			var user = userRepo.GetAllAsync().Result;

			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
