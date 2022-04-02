using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlApp.API.Controllers
{
    
    public class CabinetsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Cabinet> _service;
        private readonly ICabinetService _cabinetService;

        public CabinetsController(IMapper mapper, IGenericService<Cabinet> service, ICabinetService cabinetService)
        {
            _mapper=mapper;
            _service=service;
            _cabinetService=cabinetService;
        }


        /// <summary>
        /// Bütün  Çekmeceleri Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var cabinets = await _service.GetAllAsync();
            var cabinetsDtos = _mapper.Map<List<CabinetDto>>(cabinets.ToList());


            return CreateActionResult(CustomResponseDto<List<CabinetDto>>.Success(200, cabinetsDtos));
        }
        /// <summary>
        /// Id'ye Göre Çekmece Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var cabinet = await _service.GetByIdAsync(id);
            var cabinetsDto = _mapper.Map<CabinetDto>(cabinet);
            return CreateActionResult(CustomResponseDto<CabinetDto>.Success(200, cabinetsDto));
        }
        /// <summary>
        /// Çekmece Ekler
        /// </summary>
        /// <param name="cabinetDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(CabinetDto cabinetDto)
        {
            var cabinet = await _service.AddAsync(_mapper.Map<Cabinet>(cabinetDto));
            var cabinetsDto = _mapper.Map<CabinetDto>(cabinet);
            return CreateActionResult(CustomResponseDto<CabinetDto>.Success(201, cabinetsDto));
        }
        /// <summary>
        /// Çekmece Bilgisini Günceller
        /// </summary>
        /// <param name="cabinetDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CabinetDto cabinetDto)
        {
            await _service.UpdateAsync(_mapper.Map<Cabinet>(cabinetDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        /// <summary>
        /// Cekmece Siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cabinet = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(cabinet);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
