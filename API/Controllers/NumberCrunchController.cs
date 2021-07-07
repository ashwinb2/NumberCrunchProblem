using System.Collections.Generic;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberCrunchController : ControllerBase
    {
        private readonly ISampleScoresService _sampleScoresService;
        public NumberCrunchController(ISampleScoresService sampleScoresService)
        {
            _sampleScoresService = sampleScoresService;
        }

        [HttpPost]
        public ActionResult<List<SampleScore>> Post([FromBody] SampleScoresRequest request)
        {
            return _sampleScoresService.FormSampleScores(request);
        }
    }
}