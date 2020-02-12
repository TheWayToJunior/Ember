using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ember.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ember.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService NewsServece;

        public NewsController(INewsService newsServece)
        {
            NewsServece = newsServece ?? throw new ArgumentNullException(nameof(newsServece));
        }

        [HttpGet]
        public ActionResult<IEnumerable<NewsPost>> GetAll() => 
            Ok(NewsServece.GetAllNews());

        [HttpGet("{id}")]
        public ActionResult<NewsPost> Get(int id)
        {
            NewsPost newsPost = NewsServece.GetNewsById(id);

            if (newsPost == null)
            {
                return NotFound();
            }

            return Ok(newsPost);
        }

        [HttpPost]
        public ActionResult Post([FromBody] NewsPost value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //plug
            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] NewsPost value)
        {
            NewsPost newsPost = NewsServece.GetNewsById(id);

            if (newsPost == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //plug
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            NewsPost newsPost = NewsServece.GetNewsById(id);

            if (newsPost == null)
            {
                return NotFound();
            }

            //plug
            return NotFound();
        }
    }
}
