using System.Linq;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public abstract class RequestHandler : IAlexaSkill
    {
        protected string GetParameter(string request, string token, string defaultValue)
        {
            return request.ToLower().Split(' ').SkipWhile(w => w != token.ToLower()).Skip(1).FirstOrDefault() ??
                   defaultValue;
        }

        public abstract bool CanHandleRequest(string request);


        public abstract void HandleRequest(string request);
    }
}