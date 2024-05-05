namespace UI.Models
{
    public class HelpModel
    {
        public int HelpId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public UserModel KoTrazi { get; set; }
        //public List<UserModel> KoPomaze { get; set; }
        public Lokacija Lokacija { get; set; }
        public string Municipality { get; set; }

        public string KoPomazeIme { get; set; }
        public string KoPomazePrezime { get; set; }
        public HelpModel()
        {
            //KoPomaze = new List<UserModel>();
        }
    }
}
