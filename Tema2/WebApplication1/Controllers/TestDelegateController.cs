using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Delegate;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        delegate string MyDelegate(string value1, string value2);  //def un container

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService;
        }

        //
        [HttpGet("intro")]
        public string Introduction(string firstname, string lastname)
        {
            var callback = _delegateService.Hello;

            return _delegateService.Introduction(firstname, lastname, callback);
        }

        //conditia de la Delegate
        [HttpGet("intro-condition")]
        public string IntroductionCondition(string firstname, string lastname, bool welcome)
        {
            MyDelegate helloDelegate = _delegateService.Hello;
            //var callback1 = _delegateService.Hello;
            Func<string, string, string> byeDelegate = (firstname, lastname) => _delegateService.Bye(firstname,lastname);  //exp care primeste un parametru
            //var callback2 = (string firstname, string lastname) => $"Bye, {firstname} {lastname}";

            //string callback = welcome ? helloDelegate : byeDelegate;
            if (welcome)
            {
                Func<string, string, string> helloDel = (firstname, lastname) => helloDelegate(firstname, lastname);
                return _delegateService.Introduction(firstname, lastname, helloDel);
            }
            else
            {
                return _delegateService.Introduction(firstname, lastname, byeDelegate);
            }
        }

        //mai multe metode consecutive
        [HttpGet("intro-multi")]
        public string IntroductionMulti(string firstname, string lastname)
        {
            MyDelegate myDelegate = _delegateService.Hello;

            myDelegate += _delegateService.Bye;  //rulate in ordinea punerii, princ de coada

            Func<string, string, string> myDel = (firstname, lastname) => myDelegate(firstname, lastname);

            return _delegateService.Introduction(firstname, lastname, myDel);
        }
    }
}
