using IoT_Hotspot.Data;
using IoT_Hotspot.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Hotspot.Controllers
{
    public class SensorController : Controller
    {
        private readonly AplicationDbContext _context;

        public SensorController(AplicationDbContext context)
        {
            _context = context;
        } 

        // GET: SensorController
        public ActionResult Index()
        {
            // https://www.youtube.com/watch?v=3mu2K5vXcxc
            IEnumerable<Sensor> listSensors = _context.Sensor;
            return View(listSensors);
        }

        // GET: SensorController/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: SensorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SensorController/Create/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sensor sensor)
        {
            if (ModelState.IsValid) 
            {
                _context.Sensor.Add(sensor);
                _context.SaveChanges();
                TempData["message"] = "The sensor created succesfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        // GET: SensorController/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Ontein Sensor
            var sensor = _context.Sensor.Find(id);

            if (sensor == null) 
            {
                return NotFound();
            }

            return View(sensor);
        }

        // POST: SensorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sensor sensor)
        {
            if (ModelState.IsValid)
            {
                _context.Sensor.Update(sensor);
                _context.SaveChanges();
                TempData["message"] = "The sensor updated succesfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: SensorController/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Ontein Sensor
            var sensor = _context.Sensor.Find(id);

            if (sensor == null)
            {
                return NotFound();
            }

            return View(sensor);
        }

        // POST: SensorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSensor(int? id)
        {
                // Ontein Sensor
                var sensor = _context.Sensor.Find(id);
                if (sensor == null)
                {
                    return NotFound();
                }

                _context.Sensor.Remove(sensor);
                _context.SaveChanges();

                TempData["message"] = "The sensor deleted succesfully";
                return RedirectToAction("Index");
        }
    }
}
