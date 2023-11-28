using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Dialogue
{
    public class Response
    {
        public string responseText { get; set; }
        public Dictionary<string, Response> dialogueOptions { get; set; }
        public Dictionary<string, Func<Form>> formOptions { get; set; }

        public Response()
        {
        }
        public Response(string responseText, Dictionary<string, Response> dialogueOptions)
        {
            this.responseText = responseText;
            this.dialogueOptions = dialogueOptions;
        }
    }
}
