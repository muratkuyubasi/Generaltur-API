using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourV2.Data.Dto;
using TourV2.Data.Dto.ValuesEducation;
using TourV2.MediatR.Commands.EducaitonForm;
using TourV2.MediatR.Commands.MosqueRepository;
using TourV2.MediatR.Commands.State;
using TourV2.MediatR.Queries;
using TourV2.MediatR.Queries.EducationForm;
using TourV2.MediatR.Queries.Mosque;
using TourV2.MediatR.Queries.State;

namespace TourV2.Admin.Controllers.Education
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : BaseController
    {
        public IMediator _mediator { get; set; }

        public EducationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        ///<summary>
        ///New EducationForm
        ///</summary>
        ///<param name="addEducationFormCommand"></param>
        ///<returns></returns>
        ///
        [HttpPost("AddEducationForm")]
        [Produces("application/json", "application/xml", Type = typeof(EducationFormDTO))]
        public async Task<IActionResult> AddEducation(AddEducationFormCommand addEducationFormCommand)
        {
            var response = await _mediator.Send(addEducationFormCommand);

            if (!response.Success)
            {
                return ReturnFormattedResponse(response);
            }
            return Ok(response);

        }
      
        
        ///<summary>
        ///Get All EducationForm
        ///</summary>
        ///<returns></returns>

        [HttpGet("GetAllEducationForms")]
        [Produces("application/json", "application/xml", Type = typeof(List<EducationFormDTO>))]
        public async Task<IActionResult> GetAllContactMessages()
        {
            var query = new GetAllEducationFormQuery { };
            var result = await _mediator.Send(query);
            return Ok(result);
        }



        ///<summary>
        ///New State
        ///</summary>
        ///<param name="addEducationFormCommand"></param>
        ///<returns></returns>
        ///
        [HttpPost("AddState")]
        [Produces("application/json", "application/xml", Type = typeof(StateDto))]
        public async Task<IActionResult> AddState(AddStateCommand addStateCommand)
        {
            var response = await _mediator.Send(addStateCommand);

            if (!response.Success)
            {
                return ReturnFormattedResponse(response);
            }
            return Ok(response);
        }


        ///<summary>
        ///Get All State
        ///</summary>
        ///<returns></returns>

        [HttpGet("GetAllState")]
        [Produces("application/json", "application/xml", Type = typeof(List<StateDto>))]
        public async Task<IActionResult> GetAllState()
        {
            var query = new GetAllStateQuery { };
            var result = await _mediator.Send(query);
            return Ok(result);
        }



        ///<summary>
        ///New Mosque
        ///</summary>
        ///<param name="addMosqueCommand"></param>
        ///<returns></returns>
        ///
        [HttpPost("AddMosque")]
        [Produces("application/json", "application/xml", Type = typeof(MosqueDto))]
        public async Task<IActionResult> AddMosque(AddMosqueCommand mosqueCommand)
        {
            var response = await _mediator.Send(mosqueCommand);

            if (!response.Success)
            {
                return ReturnFormattedResponse(response);
            }
            return Ok(response);

        }

        ///<summary>
        ///Get All Mosque
        ///</summary>
        ///<returns></returns>

        [HttpGet("GetAllMosque")]
        [Produces("application/json", "application/xml", Type = typeof(List<MosqueDto>))]
        public async Task<IActionResult> GetAllMosque()
        {
            var query = new GetAllMosqueQuery { };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

    }

}