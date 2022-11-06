using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControlApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ICabinetService _cabinetService;

        public CabinetsController(IMapper mapper, IGenericService<Cabinet> service, ICabinetService cabinetService)
        {
            _mapper=mapper;

            _cabinetService=cabinetService;
        }


        /// <summary>
        /// Bütün  Çekmeceleri Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var cabinets = await _cabinetService.GetAllAsync();
            var cabinetsDtos = _mapper.Map<List<CabinetDto>>(cabinets.ToList());

            return Ok(cabinetsDtos);
        }





        /// <summary>
        /// Id'ye Göre Çekmece Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var cabinet = await _cabinetService.GetByIdAsync(id);
            var cabinetsDto = _mapper.Map<CabinetDto>(cabinet);
            if (cabinet==null)
            {
                return NotFound("İlgili Id'ye Göre Çekmece Bulunamadı");
            }
            return Ok(cabinetsDto);
        }



        //************************************************************************************************************
        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IActionResult> GetByReceiverName(string name)
        {
            return Ok();
        }
        //************************************************************************************************************




        /// <summary>
        /// Çekmece Ekler
        /// </summary>
        /// <param name="cabinetDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CabinetDto cabinetDto)
        {

            //if (ModelState.IsValid)
            //{
            //    var cabinet = await _cabinetService.AddAsync(_mapper.Map<Cabinet>(cabinetDto));
            //    var cabinetsDto = _mapper.Map<CabinetDto>(cabinet);
            //    return CreatedAtAction("GetById", new { id = cabinetDto. }, cabinetsDto);
            //}
            //return BadRequest(ModelState);
            return Ok();

            
        }
        /// <summary>
        /// Çekmece Bilgisini Günceller
        /// </summary>
        /// <param name="cabinetDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CabinetDto cabinetDto)
        {
            await _cabinetService.UpdateAsync(_mapper.Map<Cabinet>(cabinetDto));

            return Ok(cabinetDto);
         }
        /// <summary>
        /// Cekmece Siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cabinet = await _cabinetService.GetByIdAsync(id);
            await _cabinetService.DeleteAsync(cabinet);

            return CreatedAtAction("GetById", new { id = cabinet.Id }, cabinet);
          
        }

        [HttpGet("entity-specific")]
        public async Task<IActionResult> GetSpecific()
        {
            //var cabinets = await _cabinetService.GetAllAsync();
            //return Ok(cabinets.Select(c => new CabinetDto { 
            //        CreatedDate = c.CreatedDate,
            //        Id = c.Id,
            //        SpecialNo = c.SpecialNo,
            //        DeliveryDate = c.DeliveryDate,
            //        DeliveryEmployee = c.DeliveryEmployee,
            //        ReceiverEmployee = c.ReceiverEmployee,
            //    }
            //));

            return Ok();    
        }
    }
}
