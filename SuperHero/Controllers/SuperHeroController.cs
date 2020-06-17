using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Data.Migrations;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    public class SuperHeroController : Controller
    {

        private ApplicationDbContext _context;

        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            var listOfHeroes = _context.SuperHeroes.ToList();
            return View(listOfHeroes);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            var hero = _context.SuperHeroes.Where(h => h.Id == id).SingleOrDefault();
            return View(hero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHeroModel superHeroModel)
        {
            try
            {
                _context.SuperHeroes.Add(superHeroModel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
                var heroToEdit = _context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
                return View(heroToEdit);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SuperHeroModel superHeroModel)
        {
            var superHeroModelInDb = _context.SuperHeroes.Where(s => s.Id == superHeroModel.Id).Single();

            superHeroModelInDb.name = superHeroModel.name;
            superHeroModelInDb.primaryAbility = superHeroModel.primaryAbility;
            superHeroModelInDb.secondaryAbility = superHeroModel.secondaryAbility;
            superHeroModelInDb.catchPhrase = superHeroModel.catchPhrase;
            superHeroModelInDb.alterEgo = superHeroModel.alterEgo;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
            
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            var heroToDelete = _context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(heroToDelete);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SuperHeroModel superHeroModel)
        {
            try
            {
                var superHeroToDelete = _context.SuperHeroes.Find(id);
                _context.SuperHeroes.Remove(superHeroToDelete);
                _context.SaveChanges();
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}