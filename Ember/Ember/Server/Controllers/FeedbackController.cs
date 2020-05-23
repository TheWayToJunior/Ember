using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ember.Server.Services;
using Ember.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Ember.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly EmailService emailService;

        public FeedbackController(EmailService emailService, IConfiguration configuration)
        {
            this.emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }

        [HttpPost]
        public async Task<ActionResult> SendMessage([FromBody] SendMessage message)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await emailService.SendMessage(message)
                    .ConfigureAwait(true);

                return Ok("The message is sent!");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred, see logging entries");
            }
        }
    }
}