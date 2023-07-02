using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IVillaRepository _dbVilla;
        private readonly IVillaNumberRepository _dbVillaNumber;

        public VillaNumberAPIController(IMapper mapper, IVillaNumberRepository dbVillaNumber, IVillaRepository dbVilla)
        {
            _mapper = mapper;
            _dbVillaNumber = dbVillaNumber;
            _dbVilla = dbVilla;
            _response = new();
        }

        //[MapToApiVersion("2.0")]
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
