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
            formOptions = new Dictionary<string, Func<Form>>();
        }
    }
}
