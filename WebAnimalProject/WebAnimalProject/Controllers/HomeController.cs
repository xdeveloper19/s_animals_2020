using AnimalsEntity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebAnimalProject.Context;

namespace WebAnimalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AnimalsView()
        {
            ViewBag.Message = "Список животных";
            return View();
        }

        public ActionResult BirdsView()
        {
            SelectList list = new SelectList(new List<SelectListItem>
{
    new SelectListItem { Selected = true, Text = "Черный", Value = "0"},
    new SelectListItem { Selected = false, Text = "Разноцветный", Value = "1"},
    new SelectListItem { Selected = false, Text = "Белый", Value = "2"},
});

            ViewBag.Wings = list;
            ViewBag.Message = "Список птиц";
            return View();
        }

        public ActionResult MammalsView()
        {
            ViewBag.Message = "Список млекопитающих";
            return View();
        }

        public ActionResult ArtiView()
        {
            ViewBag.Message = "Список парнокопытных";
            return View();
        }



        [HttpPost]
        public bool AddAnimal(Animal md)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Animal animal = new Animal
                {
                    Age = md.Age,
                    Name = md.Name,
                    Weight = md.Weight
                };

                bd.Animals.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

       

        [HttpPost]
        public bool AddMammal(Mammal md)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Mammal animal = new Mammal
                {
                    IsSwimming = md.IsSwimming,
                    Name = md.Name,
                    Temperature = md.Temperature
                };

                bd.Mammals.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        [HttpPost]
        public bool AddArti(Artiodactyls art)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Artiodactyls animal = new Artiodactyls
                {
                    IsRum = art.IsRum,
                    Name = art.Name,
                    Hoofs = art.Hoofs
                };

                bd.Artiodactylses.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        [HttpPost]
        public bool AddBird(Bird bird)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Bird animal = new Bird
                {
                    Wings = bird.Wings,
                    Name = bird.Name,
                    IsTalking = bird.IsTalking
                };

                bd.Birds.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        [HttpGet]
        public ActionResult Animals()
        {
            List<Animal> animals = new List<Animal>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Animals.ToList();
                animals.AddRange(founded_animal);
            }

            return PartialView("Animals", animals);
        }

        [HttpGet]
        public JsonResult AnimalsJson()
        {
            List<Animal> animals = new List<Animal>();
            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Animals.ToList();
                animals.AddRange(founded_animal);
            }

            return Json(animals, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Mammals()
        {
            List<Mammal> animals = new List<Mammal>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Mammals.ToList();
                animals.AddRange(founded_animal);
            }

            return PartialView(animals);
        }

        [HttpGet]
        public JsonResult MammalsJson()
        {
            List<Mammal> animals = new List<Mammal>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Mammals.ToList();
                animals.AddRange(founded_animal);
            }

            return Json(animals, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Arti()
        {
            List<Artiodactyls> animals = new List<Artiodactyls>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Artiodactylses.ToList();
                animals.AddRange(founded_animal);
            }

            return PartialView(animals);
        }

        [HttpGet]
        public JsonResult ArtiJson()
        {
            List<Artiodactyls> animals = new List<Artiodactyls>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Artiodactylses.ToList();
                animals.AddRange(founded_animal);
            }

            return Json(animals, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Birds()
        {
            List<Bird> animals = new List<Bird>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Birds.ToList();
                animals.AddRange(founded_animal);
            }

            return PartialView(animals);
        }

        [HttpGet]
        public JsonResult BirdsJson()
        {
            List<Bird> animals = new List<Bird>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Birds.ToList();
                animals.AddRange(founded_animal);
            }

            return Json(animals, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public bool RemoveAnimals()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Animals)
                {
                    bd.Animals.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        [HttpDelete]
        public bool RemoveMammals()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Mammals)
                {
                    bd.Mammals.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        [HttpDelete]
        public bool RemoveArti()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Artiodactylses)
                {
                    bd.Artiodactylses.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        [HttpDelete]
        public bool RemoveBirds()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Birds)
                {
                    bd.Birds.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}