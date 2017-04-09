using System.Web.Http;

namespace Alexa.Controllers
{
	public class AlexaController : ApiController
	{
		[HttpPost, Route("api/alexa/demo")]
		public dynamic Pluralsight(dynamic request)
		{
			return new
			{
				version = "1.0",
				sessionAttributes = new { },
				response = new
				{
					outputSpeech = new
					{
						type = "PlainText",
						text = "Hello World"
					},
					card = new
					{
						type = "Simple",
						title = "Horoscope",
						content = "Today will provide you a new learning opportunity.  Stick with it and the possibilities will be endless."
					},
					shouldEndSession = true
				}
			};
		}

	}
}