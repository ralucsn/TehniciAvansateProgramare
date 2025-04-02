namespace WebApplication1.Services.Delegate
{
    public interface IDelegateService
    {
        string Introduction(string prenume, string nume, Func<string, string, string> callback);

        string Hello(string firstname, string lastname);

        string Bye(string firstname, string lastname);
    }
}
