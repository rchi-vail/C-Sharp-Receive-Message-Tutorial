using System;
using Microsoft.AspNetCore.Mvc;
using freeclimb.Api;
using freeclimb.Model;

namespace ReceiveMessage.Controllers {
  [Route ("/")]
  [ApiController]
  public class FreeClimbController : ControllerBase {

    [HttpPost]
    public ActionResult smsConnect (CallResult freeClimbRequest) {
        string acctId = getAcctId ();
        string apiKey = getApiKey ();
        FreeClimbClient client = new FreeClimbClient (acctId, apiKey);
        string to = freeClimbRequest.getFrom;
        string from = "+19809396134";
        client.getMessagesRequester.create(from, to, "Hello from the C# SDK!");
      
        Console.WriteLine("to: "+to);
        Console.WriteLine("from: "+from);

        return Ok();
    }

    private string getAcctId () {
        return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
    }

    private string getApiKey () {
        return System.Environment.GetEnvironmentVariable("API_KEY");
    }
  }
}
