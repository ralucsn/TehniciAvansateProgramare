using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Lambda;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        //i. expresie fara parametri
        [HttpGet("withoutP-lowercase")]
        public string ToLowerCaseWithoutP(string value1, string value2)
        {
            Func<string> result = () => _lambdaService.ToLowerCase(value1);
            return result();
        }

        //ii. expresie cu 1 parametru folosind block statement
        [HttpGet("one-param-try-parse")]
        public string OneParamTryParse(string value)
        {
            Func<string, string> result = (param1) =>
            {
                if(_lambdaService.TryParseNumber(param1) == true)
                {
                    return "Number";
                }
                else
                {
                    return "Not number";
                }
            };
            return result(value);
        }

        //iii. expresie cu 2 parametri
        [HttpGet("two-param")]
        public string TwoParam(int param1, int param2)
        {
            var concatenateLambda = string (int p1, int p2) => p1.ToString() + p2.ToString();  //concatenam 2 nr

            return concatenateLambda(param1, param2);
        }

        //iv. exprsie cu unused parameters
        [HttpGet("unused-lower-case-delayed")]
        public string ToLowerCaseDelayed(string folosit, string nefolosit)
        {
            //var result = _lambdaService.ToLowerCaseDelayed(value).Result;
            Func<string, string, string> result = (value1, _) => _lambdaService.ToLowerCaseDelayed(value1).Result;
            return result(folosit, nefolosit);
        }

        //v. expresie cu default value
        [HttpGet("default-try-parse-number")]
        public string TryParseNumber(string value = "0")  //ii punem valoarea de default 0
        {
            return _lambdaService.TryParseNumber(value) ? "Number" : "Not number";
        }

        //vi. expresie cu tuple
        [HttpGet("tuple-split-number")]
        public string SplitNumber((int, int, int) value)
        {
            //var tupleValue = _lambdaService.SplitNumber(value);
            return $"{value.Item1} / {value.Item2} / {value.Item3}";
        }
    }
}
