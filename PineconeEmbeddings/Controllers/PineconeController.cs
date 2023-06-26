using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PineconeEmbeddings.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class PineconeController : ControllerBase
    {
        private readonly PineconeService _service;
        public PineconeController()
        {
            _service= new PineconeService();
        }

        [HttpPost]
        public ActionResult<string> PostQuestion(List<double> list)
        {
            var result =_service.FindSimilarText(list);
            return result;
        }
    }
}
