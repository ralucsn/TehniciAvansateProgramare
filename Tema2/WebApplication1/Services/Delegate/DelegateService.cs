namespace WebApplication1.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public string Introduction(string prenume, string nume, Func<string, string, string> callback)
        {
            var firstname = prenume.ToUpper();
            var lastname = nume.ToUpper();
            return callback(firstname, lastname);
        }

        public string Hello(string firstname, string lastname)
        {
            return $"Hello, {firstname} {lastname}";
        }


        //am facut o functie separata pentru Bye
        public string Bye(string firstname, string lastname)
        {
            return $"Bye, {firstname} {lastname}";  //are aceiasi semnatura ca si mai sus, cum am facut la lab
        }
    }
}
