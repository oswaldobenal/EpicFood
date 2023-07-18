using System;
namespace EpicFood_API.Models
{
	public class User
	{
		public string userId { get; set; }

		public string user { get; set; }

		public string password { get; set; }

		public string rol { get; set; }

		public static List<User> DB()
		{
			var list = new List<User>()
			{
				new User
				{
					userId = "1",
					user = "Julian",
					password = "123.",
					rol = "empleado"
				}
			};
			return list;
		}
	}
}

