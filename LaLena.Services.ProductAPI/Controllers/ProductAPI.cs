using LaLena.Services.ProductAPI.DbContexts.Models.Dto;
using LaLena.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LaLena.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductAPI : ControllerBase
    {

        protected ResponseDto _response;

        private IProductRepository _productRepository;

        public ProductAPI(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            this._response = new ResponseDto();
        }


        [HttpGet]
        public async Task<object> Get()
        {

            try
            {
                IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
                _response.IsSuccess = true;
                _response.Result = productDtos;
                _response.DisplayMessage = "";
            }

            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDto productDto = await _productRepository.GetProductById(id);

                _response.IsSuccess = true;
                _response.Result = productDto;
                _response.DisplayMessage = "";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]

        public async Task<object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto model = await _productRepository.CreateUpdateProduct(productDto);

                _response.IsSuccess = true;
                _response.Result = productDto;
                _response.DisplayMessage = "";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut]

        public async Task<object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto model = await _productRepository.CreateUpdateProduct(productDto);

                _response.IsSuccess = true;
                _response.Result = productDto;
                _response.DisplayMessage = "";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete]

        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _productRepository.DeleteProduct(id);
                _response.IsSuccess = isSuccess;
                _response.DisplayMessage = "";

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

    }
}
