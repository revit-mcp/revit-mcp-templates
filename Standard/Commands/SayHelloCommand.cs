using Autodesk.Revit.UI;
using Newtonsoft.Json.Linq;
using revit_mcp_sdk.API.Base;
using revit_mcp_sdk.API.Models;

namespace Standard.Commands
{
    public class SayHelloCommand : ExternalEventCommandBase
    {
        private SayHelloEventHandler _handler => (SayHelloEventHandler)Handler;

        public override string CommandName => "say_hello";

        public SayHelloCommand(UIApplication uiApp)
        : base(new SayHelloEventHandler(), uiApp)
        {
        }

        public override object Execute(JObject parameters, string requestId)
        {
            RaiseAndWaitForCompletion(15000);
            return CommandResult.CreateSuccess(new { execute = true });
        }
    }
}
