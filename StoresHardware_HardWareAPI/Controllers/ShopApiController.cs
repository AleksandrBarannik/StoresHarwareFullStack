using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Models.Dto;
using StoresHardware_HardWareAPI.Repository.IRepository;
using System.Net;

namespace StoresHardware_HardWareAPI.Controllers
{
    [Route("api/Shop")]
    [ApiController]
    public class ShopApiController : ControllerBase
    {
        protected ApiResponse _response;
        private readonly IShopRepository _dbShop;
        private readonly IMapper _mapper;
        public ShopApiController(IShopRepository dbShop, IMapper mapper)
        {
            _dbShop = dbShop;
            _mapper = mapper;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> GetShops()
        {
            try
            {

                IEnumerable<Shop> shopList;
                shopList = await _dbShop.GetAllAsync();
                _response.Result = _mapper.Map<List<ShopDto>>(shopList);
                _response.SucsessResponse(HttpStatusCode.OK);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetShop")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> GetShop(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var shop = await _dbShop.GetAsync(u => u.ShopId == id);

                if (shop == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<ShopDto>(shop);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]        
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse>> CreateShop([FromBody] ShopCreateDto shopCreateDto)
        {
            try
            {
                if (await _dbShop.GetAsync(u => u.ShopId == shopCreateDto.ShopId) != null)
                {
                    ModelState.AddModelError("ErrorMessages", "Shop already Exsist");
                    return BadRequest(ModelState);
                }

                if (shopCreateDto == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                Shop shop = _mapper.Map<Shop>(shopCreateDto);
                await _dbShop.CreateAsync(shop);
                _response.Result = _mapper.Map<ShopCreateDto>(shop);
                _response.SucsessResponse(HttpStatusCode.Created);
                return CreatedAtRoute("GetShop", new { id = shop.ShopId }, shop);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpPut("{id:int}", Name = "UpdateShop")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<ApiResponse>> UpdateShop(int id, [FromBody] ShopDto updateDto)
        {
            try
            {
                if (updateDto == null || id != updateDto.ShopId)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                Shop updatingShop = _mapper.Map<Shop>(updateDto);
                await _dbShop.UpdateAsync(updatingShop);
                _response.SucsessResponse(HttpStatusCode.NoContent);
                return Ok(_response);

            }
            catch (Exception ex) 
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;

        }

        [HttpDelete("{id:int}", Name = "DeleteShop")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]        
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> DeleteShop(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var shop = await _dbShop.GetAsync(u => u.ShopId == id);

                if (shop == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _dbShop.RemoveAsync(shop);
                _response.SucsessResponse(HttpStatusCode.NoContent);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }


    }
}
