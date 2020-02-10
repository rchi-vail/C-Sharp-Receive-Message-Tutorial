using com.freeclimb;
using com.freeclimb.percl;
using com.freeclimb.webhooks.call;
using System;
using Microsoft.AspNetCore.Mvc;
using com.freeclimb;
using com.freeclimb.api;

namespace ReceiveMessage.Controllers {
  [Route ("inboundSms")]
  [ApiController]
  public class FreeClimbController : ControllerBase {

    [HttpPost]
    public ActionResult smsConnect (CallStatusCallback freeClimbRequest) {
        string acctId = getAcctId ();
        string acctToken = getAuthToken ();
        FreeClimbClient client = new FreeClimbClient (acctId, acctToken);
        string to = freeClimbRequest.getFrom;
        string from = "+19159969243";
        string appId = "APda384d410b8a6df51fc54ed1abdeaad380d627db";
        client.getMessagesRequester.create(from, to, "Hello from the C# SDK!");
       
        // Convert PerCL container to JSON and append to response
        return Ok();
    }

    private string getAcctId () {
        return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
    }

    private string getAuthToken () {
        return System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
    }
  }
}