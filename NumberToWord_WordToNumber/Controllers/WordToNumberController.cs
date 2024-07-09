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
    [Route("Word To Number")]
    public class WordToNumberController : ControllerBase
    {

        [HttpPost]
        [Route("Insert the Word to convert a number")]
        public dynamic convertW(string n)
        {

            convert converted = new convert();

            INPUT NEW = new INPUT(n);

            OUTPUT exit = new OUTPUT(converted.convertw(NEW));

            return  exit.GetResult();

        }



    }
}
