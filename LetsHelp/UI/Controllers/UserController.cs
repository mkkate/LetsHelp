using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User/AddUser
        public ActionResult AddUser()
        {
            UserModel model = new UserModel();
            model.FirstName = "Emilija";
            model.LastName = "Krstic";
            model.BirthYear = 1958;
            model.Mesto = "Pozarevac";
            model.Opstina = "Golubac";
            //model.KoTrazi = u1;

            /*HelpModel h1 = new HelpModel();
            h1.HelpId = 1;
            h1.Title = "Pomoc oko dvorista";
            h1.Description = "Treba pokositi travu";
            h1.Type = "Dvoriste";
            h1.DateFrom = new DateTime(2023, 10, 22);//.ToString("dd/MMMM/yyyy");

            // trazi pomoc
            UserModel u1 = new UserModel();
            u1.FirstName = "Kristina";
            u1.LastName = "Krstic";
            u1.BirthYear = 1958;
            u1.Mesto = "Pozarevac";
            u1.Opstina = "Golubac";
            h1.KoTrazi = u1;

            // pomazu
            UserModel u2 = new UserModel();
            u1.FirstName = "Anja";
            u1.LastName = "Savic";
            u1.BirthYear = 1998;
            u1.Mesto = "Pozarevac";
            u1.Opstina = "Beranje";
            h1.KoPomaze.Add(u2);
            UserModel u3 = new UserModel();
            u1.FirstName = "Milan";
            u1.LastName = "Stanic";
            u1.BirthYear = 1992;
            u1.Mesto = "Pozarevac";
            u1.Opstina = "Ostrovo";
            h1.KoPomaze.Add(u3);

            model.PruzenePomoci.Add(h1);
            */

            return View(model);
        }

        public ActionResult AddUserSaListama()
        {
            return View();
        }

        public ActionResult UserList()
        {
            List<UserModel> users = new List<UserModel>();

            UserModel u1 = new UserModel();
            u1.UserId = 1;
            u1.FirstName = "Kristina";
            u1.LastName = "Krstic";
            u1.BirthYear = 1958;
            u1.Mesto = "Pozarevac";
            u1.Opstina = "Golubac";
            //h1.KoTrazi = u1;
            users.Add(u1);

            // pomazu
            UserModel u2 = new UserModel();
            u2.UserId = 2;
            u2.FirstName = "Anja";
            u2.LastName = "Savic";
            u2.BirthYear = 1998;
            u2.Mesto = "Pozarevac";
            u2.Opstina = "Beranje";
            //h1.KoPomaze.Add(u2);
            users.Add(u2);

            UserModel u3 = new UserModel();
            u3.UserId = 3;
            u3.FirstName = "Milan";
            u3.LastName = "Stanic";
            u3.BirthYear = 1992;
            u3.Mesto = "Pozarevac";
            u3.Opstina = "Ostrovo";
            //h1.KoPomaze.Add(u3);
            users.Add(u3);

            return View(users);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
