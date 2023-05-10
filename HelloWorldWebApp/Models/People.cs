using System.Text.Json;
using System.Text.Json.Serialization;

namespace HelloWorldWebApp.Models
{
	public class People
	{
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Deskripsi { get; set; }

		public override string ToString() => JsonSerializer.Serialize<People>(this);
	}
}
