using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestingWebApp.Models;
using System.Collections.Generic;

namespace TestingWebApp.Controllers
{
    [Route("api/journal")]
    [ApiController]
    public class JournalController : ControllerBase
    {
        private readonly JournalContext _context;

        public JournalController(JournalContext context)
        {
            _context = context;

            if (_context.JournalEntries.Count() == 0)
            {
                _context.JournalEntries.Add(new JournalEntryModel { PlannedTasks = "Entry1" });
                _context.SaveChanges();
            }
        }

        public ActionResult<List<JournalEntryModel>> GetAll()
        {
            return _context.JournalEntries.ToList();
        }

        [HttpGet("{id}", Name = "GetEntries")]
        public ActionResult<JournalEntryModel> GetById(int id)
        {
            var entry = _context.JournalEntries.Find(id);
            if (entry == null)
            {
                return NotFound();
            }
            return entry;
        }
        [HttpPost]
        public IActionResult Create(JournalEntryModel model)
        {
            
            _context.JournalEntries.Add(model.PlannedTasks);
            _context.SaveChanges();

            return CreatedAtRoute("GetEntry", new { id = model.PlannedTasks.id }, model.PlannedTasks);
        }


    }
}