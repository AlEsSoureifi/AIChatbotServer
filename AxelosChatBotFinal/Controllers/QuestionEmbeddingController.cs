using AxelosChatBotFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AxelosChatBotFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionEmbeddingController : ControllerBase
    {
        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<QuestionEmbedding>> PostTodoItem(QuestionEmbedding emb)
        {
            //Project B.Program ab = new Project B.Program();
            //ab.sayhello();


            return Ok();
        }
    }
}
