using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoresHardware_HardWareAPI.Models.Dto;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Repository.IRepository;
using System.Net;

namespace StoresHardware_HardWareAPI.Controllers
{
    [Route("api/ProductCat")]
    [ApiController]
    public class ProductCatApiController: ControllerBase
    {
        protected ApiResponse _response;
        private readonly IProductCategoryRepository _dbProductCategory;
        private readonly IMapper _mapper;
        public ProductCatApiController(IProductCategoryRepository dbProductCategory, IMapper mapper)
        {
            _dbProductCategory = dbProductCategory;
            _mapper = mapper;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> GetProductCategories()
        {
            try
            {

                IEnumerable<ProductCategory> productCategoryList = await _dbProductCategory.GetAllAsync();
                _response.Result = _mapper.Map<List<ProductCategoryDto>>(productCategoryList);
                _response.SucsessResponse(HttpStatusCode.OK);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetProductCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> GetProductCategory(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var productCategory = await _dbProductCategory.GetAsync(u => u.CategoryId == id);

                if (productCategory == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<ProductCategoryDto>(productCategory);
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
        public async Task<ActionResult<ApiResponse>> CreateProductCategory([FromBody] ProductCategoryDto createDto)
        {
            try
            {
                if (await _dbProductCategory.GetAsync(u => u.CategoryId == createDto.CategoryId) != null)
                {
                    ModelState.AddModelError("ErrorMessages", "ProductCategory already Exsist");
                    return BadRequest(ModelState);
                }

                if ( createDto == null )
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                ProductCategory productCategory = _mapper.Map<ProductCategory>(createDto);
                await _dbProductCategory.CreateAsync(productCategory);
                _response.Result = _mapper.Map<ProductCategoryDto>(productCategory);
                _response.SucsessResponse(HttpStatusCode.Created);
                return CreatedAtRoute("GetProductCategory", new { id = productCategory.CategoryId }, productCategory);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeleteProductCategory")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> DeleteProductCategory(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var producCategory = await _dbProductCategory.GetAsync(u => u.CategoryId == id);

                if (producCategory == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _dbProductCategory.RemoveAsync(producCategory);
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
