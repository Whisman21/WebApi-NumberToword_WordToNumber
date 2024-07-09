using Microsoft.AspNetCore.Mvc;
using NumberToWord_WordToNumber.NewFolder;
using NumberToWord_WordToNumber.Resources;
using NumberToWors_WordToNumber;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
namespace NumberToWord_WordToNumber.Controllers
{

    [ApiController]
    [Route("Number To Word")]
    public class NumberToWordController : ControllerBase
    {

        [HttpPost]
        [Route("Insert the number to convert a word (1-999999999)")]
        public dynamic convertN(int n)
        {

            convert converted = new convert();

            INPUT NEW = new INPUT(n);

            OUTPUT exit = new OUTPUT(converted.convertn(NEW));

            return exit.GetResult();
                
           
        }

    }
}
