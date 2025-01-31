﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Demo_react.Models;

namespace Demo_react.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblCitiesController : ControllerBase
    {
        private readonly demo_reactContext _context;

        public TblCitiesController(demo_reactContext context)
        {
            _context = context;
        }

        // GET: api/TblCities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblCities>>> GetTblCities()
        {
            return await _context.TblCities.ToListAsync();
        }

        // GET: api/TblCities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCities>> GetTblCities(int id)
        {
            var tblCities = await _context.TblCities.FindAsync(id);

            if (tblCities == null)
            {
                return NotFound();
            }

            return tblCities;
        }

        // PUT: api/TblCities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCities(int id, TblCities tblCities)
        {
            if (id != tblCities.CityId)
            {
                return BadRequest();
            }

            _context.Entry(tblCities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCitiesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TblCities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCities>> PostTblCities([FromForm] TblCities tb)
        {
            
            _context.TblCities.Add(tb);
            await _context.SaveChangesAsync();

            return Ok();
        }
        // DELETE: api/TblCities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCities>> DeleteTblCities(int id)
        {
            var tblCities = await _context.TblCities.FindAsync(id);
            if (tblCities == null)
            {
                return NotFound();
            }

            _context.TblCities.Remove(tblCities);
            await _context.SaveChangesAsync();

            return tblCities;
        }

        private bool TblCitiesExists(int id)
        {
            return _context.TblCities.Any(e => e.CityId == id);
        }
    }
}
