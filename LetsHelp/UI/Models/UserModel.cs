namespace UI.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int BirthYear { get; set; }
        public char Gender { get; set; }
        public string Mesto { get; set; }
        public string Opstina { get; set; }
        public List<UserModel> Posrednici { get; set; }
        public List<HelpModel> PruzenePomoci { get; set; }
        public List<HelpModel> TrazenePomoci { get; set; }

        public UserModel()
        {
            Posrednici = new List<UserModel>();
            PruzenePomoci = new List<HelpModel>();
            TrazenePomoci = new List<HelpModel>();
        }
    }
}
