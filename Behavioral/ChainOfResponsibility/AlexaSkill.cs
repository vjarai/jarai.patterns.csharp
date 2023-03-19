using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public abstract class AlexaSkill
    {
        protected string GetFirstWordAfter(string request, string token, string defaultValue)
        {
            return request.ToLower().Split(' ').SkipWhile( w => w != token.ToLower()).Skip(1).FirstOrDefault() ?? defaultValue;
        }

        public abstract bool CanHandleRequest(string request);


        public abstract void HandleRequest(string request);

    }
}