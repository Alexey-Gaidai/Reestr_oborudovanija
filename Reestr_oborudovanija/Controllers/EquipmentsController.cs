using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reestr_oborudovanija;
using Reestr_oborudovanija.Models;
using Reestr_oborudovanija.Models.Client;

namespace Reestr_oborudovanija.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private readonly ReestrContext _context;
        private readonly ILogger _logger;

        public EquipmentsController(ReestrContext context, ILogger<EquipmentsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Equipments
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipments()
        {
            _logger.LogInformation($"Пользователь {Request.Headers["Username"]} совершил запрос оборудования", DateTime.UtcNow.ToLongTimeString());
            return await _context.Equipments.ToListAsync();
        }

        // GET: api/Equipments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipment>> GetEquipment(int id)
        {
            var equipment = await _context.Equipments.FindAsync(id);

            if (equipment == null)
            {
                return NotFound();
            }

            return equipment;
        }

        // PUT: api/Equipments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipment(int id, EquipmentClient newEquipment)
        {
            var equipment = new Equipment
            {
                Id = newEquipment.Id,
                Name = newEquipment.Name,
                NameInList = newEquipment.NameInList,
                Accounting = newEquipment.Accounting,
                InventoryNumber = newEquipment.InventoryNumber,
                BalanceValue = newEquipment.BalanceValue,
                Depreciation = newEquipment.Depreciation,
                ResidualValue = newEquipment.ResidualValue,
                CountInList = newEquipment.CountInList,
                CountFact = newEquipment.CountFact,
                State_id = newEquipment.State_id,
                Usages = newEquipment.Usages,
                Status_id = newEquipment.Status_id,
                TransferTo = newEquipment.TransferTo,
                Required = newEquipment.Required,
                Storage_id = newEquipment.Storage_id
            };
            
            if (id != equipment.Id)
            {
                return BadRequest();
            }

            _context.Entry(equipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentExists(id))
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

        // POST: api/Equipments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Equipment>> PostEquipment(EquipmentClient newEquipment)
        {
            var equipment = new Equipment
            {
                Id = newEquipment.Id,
                Name = newEquipment.Name,
                NameInList = newEquipment.NameInList,
                Accounting = newEquipment.Accounting,
                InventoryNumber = newEquipment.InventoryNumber,
                BalanceValue = newEquipment.BalanceValue,
                Depreciation = newEquipment.Depreciation,
                ResidualValue = newEquipment.ResidualValue,
                CountInList = newEquipment.CountInList,
                CountFact = newEquipment.CountFact,
                State_id = newEquipment.State_id,
                Usages = newEquipment.Usages,
                Status_id = newEquipment.Status_id,
                TransferTo = newEquipment.TransferTo,
                Required = newEquipment.Required,
                Storage_id = newEquipment.Storage_id
            };
            _context.Equipments.Add(equipment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipment", new { id = equipment.Id }, equipment);
        }

        // DELETE: api/Equipments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipment(int id)
        {
            var equipment = await _context.Equipments.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }

            _context.Equipments.Remove(equipment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EquipmentExists(int id)
        {
            return _context.Equipments.Any(e => e.Id == id);
        }
    }
}
