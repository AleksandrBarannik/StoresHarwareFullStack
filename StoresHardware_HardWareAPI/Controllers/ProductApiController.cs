using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Models.Dto;
using StoresHardware_HardWareAPI.Repository.IRepository;
using System.Net;

namespace StoresHardware_HardWareAPI.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        protected ApiResponse _response;
        private readonly IProductRepository _dbProduct;
        private readonly IMapper _mapper;

        public ProductApiController(IProductRepository dbProduct, IMapper mapper)
        {
            _dbProduct = dbProduct;
            _mapper = mapper;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> GetProducts()
        {
            try
            {

                IEnumerable<Product> productList = await _dbProduct.GetAllAsync();
                _response.Result = _mapper.Map<List<ProductDto>>(productList);
                _response.SucsessResponse(HttpStatusCode.OK);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> GetProduct(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var product = await _dbProduct.GetAsync(u => u.ProductId == id);

                if (product == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<ProductDto>(product);
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
        public async Task<ActionResult<ApiResponse>> CreateProduct([FromBody] ProductCreateDto createDto)
        {
            try
            {
                if (await _dbProduct.GetAsync(u => u.ProductId == createDto.ProductId) != null)
                {
                    ModelState.AddModelError("ErrorMessages", "Product already Exsist");
                    return BadRequest(ModelState);
                }

                if (await _dbProduct.GetAsync(u => u.ShopId == createDto.ShopId) == null)
                {
                    ModelState.AddModelError("ErrorMessages", "Shop ID is Invalid");
                    return BadRequest(ModelState);
                }

                if (await _dbProduct.GetAsync(u => u.CategoryId == createDto.CategoryId) == null)
                {
                    ModelState.AddModelError("ErrorMessages", "ProductCategory ID is Invalid");
                    return BadRequest(ModelState);
                }


                if (createDto == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                Product product = _mapper.Map<Product>(createDto);
                await _dbProduct.CreateAsync(product);
                _response.Result = _mapper.Map<ProductCreateDto>(product);
                _response.SucsessResponse(HttpStatusCode.Created);
                return CreatedAtRoute("GetProduct", new { id = product.ProductId }, product);
            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;
        }

        [HttpPut("{id:int}", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<ApiResponse>> UpdateProduct(int id, [FromBody] ProductDto updateDto)
        {
            try
            {
                if (updateDto == null || id != updateDto.ShopId)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                Product updatingProduct = _mapper.Map<Product>(updateDto);
                await _dbProduct.UpdateAsync(updatingProduct);
                _response.SucsessResponse(HttpStatusCode.NoContent);
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.FailedResponse(ex.ToString());
            }
            return _response;

        }

        [HttpDelete("{id:int}", Name = "DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> DeleteProduct(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var product = await _dbProduct.GetAsync(u => u.ProductId == id);

                if (product == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _dbProduct.RemoveAsync(product);
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
