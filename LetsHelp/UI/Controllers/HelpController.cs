using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class HelpController : Controller
    {
        public ActionResult CreateHelp()
        {
            HelpModel h1 = new HelpModel();
            h1.HelpId = 1;
            h1.Municipality = "Beograd";
            h1.Title = "Pomoc oko dvorista";
            h1.Description = "Treba pokositi travu";
            h1.Type = "Dvoriste";
            h1.DateFrom = new DateTime(2023, 10, 22);//.ToString("dd/MMMM/yyyy");

            return View(h1);
        }

        public ActionResult ListAllHelps()
        {
            List<HelpModel> helps = new List<HelpModel>();

            // h1
            HelpModel h1 = new HelpModel();
            h1.HelpId = 1;
            h1.Title = "Pomoc oko dvorista";
            h1.Description = "Treba pokositi travu";
            h1.Type = "Dvoriste";
            h1.DateFrom = new DateTime(2023, 10, 22, 8, 45, 00);//.ToString("dd/MMMM/yyyy");
            h1.DateTo = new DateTime(2023, 10, 24, 14, 32, 00);
            h1.KoPomazeIme = "Kristina";
            h1.KoPomazePrezime = "Nikolic";
            /*UserModel u1 = new UserModel();
            u1.FirstName = "Kristina";
            u1.LastName = "Krstic";
            u1.BirthYear = 1958;
            u1.Mesto = "Pozarevac";
            u1.Opstina = "Golubac";*/
            //h1.KoPomaze.Add(u1);

            helps.Add(h1);


            // h2
            HelpModel h2 = new HelpModel();
            h2.HelpId = 2;
            h2.Title = "Krecenje stana";
            h2.Description = "Potrebno je da mi neko pomogne u krecenju trosobnog stana";
            h2.Type = "Krecenje";
            h2.DateFrom = new DateTime(2023, 8, 22, 8, 45, 00);//.ToString("dd/MMMM/yyyy");
            h2.DateTo = new DateTime(2023, 9, 24, 19, 32, 00);
            h2.KoPomazeIme = "Andjela";
            h2.KoPomazePrezime = "Milutinovic";
            helps.Add(h2);

            return View(helps);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
