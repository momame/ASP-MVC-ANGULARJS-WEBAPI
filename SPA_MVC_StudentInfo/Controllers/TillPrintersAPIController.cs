using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SPA_MVC_PCDB.Models;

namespace SPA_MVC_StudentInfo.Controllers
{
    public class TillPrintersAPIController : ApiController
    {
        private CASPackingEntities db = new CASPackingEntities();

        // GET: api/TillPrintersAPI
        public IQueryable<TillPrinter> GetTillPrinters()
        {
            return db.TillPrinters;
        }

        // GET: api/TillPrintersAPI/5
        [ResponseType(typeof(TillPrinter))]
        public IHttpActionResult GetTillPrinter(int id)
        {
            TillPrinter tillPrinter = db.TillPrinters.Find(id);
            if (tillPrinter == null)
            {
                return NotFound();
            }

            return Ok(tillPrinter);
        }

        // PUT: api/TillPrintersAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTillPrinter(int id, TillPrinter tillPrinter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tillPrinter.TillPrinterID)
            {
                return BadRequest();
            }

            db.Entry(tillPrinter).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TillPrinterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TillPrintersAPI
        [ResponseType(typeof(TillPrinter))]
        public IHttpActionResult PostTillPrinter(TillPrinter tillPrinter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TillPrinters.Add(tillPrinter);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tillPrinter.TillPrinterID }, tillPrinter);
        }

        // DELETE: api/TillPrintersAPI/5
        [ResponseType(typeof(TillPrinter))]
        public IHttpActionResult DeleteTillPrinter(int id)
        {
            TillPrinter tillPrinter = db.TillPrinters.Find(id);
            if (tillPrinter == null)
            {
                return NotFound();
            }

            db.TillPrinters.Remove(tillPrinter);
            db.SaveChanges();

            return Ok(tillPrinter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TillPrinterExists(int id)
        {
            return db.TillPrinters.Count(e => e.TillPrinterID == id) > 0;
        }
    }
}