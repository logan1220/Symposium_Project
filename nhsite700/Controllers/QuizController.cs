using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nhsite700.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            // Get Post Params Here
            int group1 = 0, group2 = 0, group3 = 0, group4 = 0;
            string question1 = collection["question1"];

            if (collection["question1"] == "Play video games")
            {
                group1++;
            }
            else if (collection["question1"] == "Watch Anime")
            {
                group2++;
            }
            else if (collection["question1"] == "Read a Comic Book")
            {
                group3++;
            }
            else if (collection["question1"] == "Catch up on Tech news")
            {
                group4++;
            }

            if (collection["question1"] == "Play video games")
            {
                group1++;
            }
            else if (collection["question1"] == "Watch Anime")
            {
                group2++;
            }
            else if (collection["question1"] == "Read a Comic Book")
            {
                group3++;
            }
            else if (collection["question1"] == "Catch up on Tech news")
            {
                group4++;
            }

            if (collection["question2"] == "A new iPhone")
            {
                group4++;
            }
            else if (collection["question2"] == "Arcade Machine")
            {
                group1++;
            }
            else if (collection["question2"] == "Tickets to Marvel's Infinity War")
            {
                group3++;
            }
            else if (collection["question2"] == "A Trip to Japan")
            {
                group2++;
            }

            if (collection["question3"] == "A live action Naruto film")
            {
                group2++;
            }
            else if (collection["question3"] == "Star Wars and Star Trek mash-up")
            {
                group4++;
            }
            else if (collection["question3"] == "Marvel vs DC")
            {
                group3++;
            }
            else if (collection["question3"] == "Assassin's Creed")
            {
                group1++;
            }

            if (collection["question4"] == "Japan")
            {
                group2++;
            }
            else if (collection["question4"] == "Silicon Valley")
            {
                group4++;
            }
            else if (collection["question4"] == "Hyrule")
            {
                group1++;
            }
            else if (collection["question4"] == "Stan Lee's Mansion")
            {
                group3++;
            }

            if (collection["question5"] == "Anime Club")
            {
                group2++;
            }
            else if (collection["question5"] == "The Game Room")
            {
                group1++;
            }
            else if (collection["question5"] == "A Computer Lab")
            {
                group4++;
            }
            else if (collection["question5"] == "The Library")
            {
                group3++;
            }

            if (collection["question6"] == "Tech Reviewer")
            {
                group4++;
            }
            else if (collection["question6"] == "Comic Book Artist")
            {
                group3++;
            }
            else if (collection["question6"] == "Video Game Tester")
            {
                group1++;
            }
            else if (collection["question6"] == "Professional Cosplayer")
            {
                group2++;
            }

            if (collection["question7"] == "SyFy")
            {
                group4++;
            }
            else if (collection["question7"] == "Fantasy")
            {
                group1++;
            }
            else if (collection["question7"] == "Animation")
            {
                group2++;
            }
            else if (collection["question7"] == "Super Hero")
            {
                group3++;
            }

            if (collection["question8"] == "Apple vs Microsoft")
            {
                group4++;
            }
            else if (collection["question8"] == "Xbox vs Sony")
            {
                group1++;
            }
            else if (collection["question8"] == "Naruto vs Sasuke")
            {
                group2++;
            }
            else if (collection["question8"] == "Batman vs Supemrman")
            {
                group3++;
            }

            if (collection["question9"] == "Stan Lee")
            {
                group3++;
            }
            else if (collection["question9"] == "Steve Jobs")
            {
                group4++;
            }
            else if (collection["question9"] == "Hideo Kojima")
            {
                group1++;
            }
            else if (collection["question9"] == "Akira Toryama")
            {
                group2++;
            }

            if (collection["question10"] == "Gamestop")
            {
                group1++;
            }
            else if (collection["question10"] == "Oriental Market")
            {
                group2++;
            }
            else if (collection["question10"] == "Barnes & Nobel")
            {
                group3++;
            }
            else if (collection["question10"] == "Best Buy")
            {
                group4++;
            }

            if (collection["question11"] == "Marvel")
            {
                group3++;
            }
            else if (collection["question11"] == "Michael Bay")
            {
                group4++;
            }
            else if (collection["question11"] == "Quentin Tarantino")
            {
                group1++;
            }
            else if (collection["question11"] == "Studio Ghibli")
            {
                group2++;
            }

            if (collection["question12"] == "Attack on Titan")
            {
                group2++;
            }
            else if (collection["question12"] == "Mythbusters")
            {
                group4++;
            }
            else if (collection["question12"] == "The Walking Dead")
            {
                group1++;
            }
            else if (collection["question12"] == "Agents of Sheild")
            {
                group3++;
            }

            if (collection["question13"] == "Designing or building something")
            {
                group4++;
            }
            else if (collection["question13"] == "Raiding a dungeon with friends")
            {
                group1++;
            }
            else if (collection["question13"] == "Cosplying as your favorite character")
            {
                group2++;
            }
            else if (collection["question13"] == "LARPing")
            {
                group3++;
            }

            if (collection["question14"] == "Self-driving cars")
            {
                group4++;
            }
            else if (collection["question14"] == "Jetpacks")
            {
                group3++;
            }
            else if (collection["question14"] == "Fully immersive Virtual Reality")
            {
                group1++;
            }
            else if (collection["question14"] == "Mech-suits")
            {
                group2++;
            }

            if (collection["question15"] == "Anime News Network")
            {
                group2++;
            }
            else if (collection["question15"] == "Polygon")
            {
                group1++;
            }
            else if (collection["question15"] == "TechChrunch")
            {
                group4++;
            }
            else if (collection["question15"] == "NewsaRama")
            {
                group3++;
            }

            List<string> links = new List<string>();

            if (group1 > 4) { links.Add("Video Game Group: https://discord.gg/Kw2dGdn"); }
            if (group2 > 4) { links.Add("Anime Group: https://discord.gg/DEHuzVt"); }
            if (group3 > 4) { links.Add("Comic Book Group: https://discord.gg/qYYp3TA"); }
            if (group4 > 4) { links.Add("Tech Group: https://discord.gg/Ct7hADe"); }

            ViewBag.links = links;

            return View("Success");
        }
    }
}