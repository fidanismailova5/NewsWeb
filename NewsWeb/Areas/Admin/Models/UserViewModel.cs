namespace NewsWeb.Areas.Admin.Models
{
    public class UserViewModel
    {
        public int Id { get; set; } 
        public string Email { get; set ; }  
        public string Password { get; set; }
		public bool RememberMe { get; set; } = false;

		public string ReturnUrl { get; set; }
	}
}
