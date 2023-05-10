using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using HelloWorldWebApp.Models;
using Microsoft.AspNetCore.Hosting;

namespace ContosoCrafts.WebSite.Services
{
	public class JsonFilePeopleService
	{
		public JsonFilePeopleService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		public IWebHostEnvironment WebHostEnvironment { get; }

		private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json");

		public IEnumerable<People> GetPeople()
		{
			using var jsonFileReader = File.OpenText(JsonFileName);
			return JsonSerializer.Deserialize<People[]>(jsonFileReader.ReadToEnd(),
				new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true
				});
		}


	}
}