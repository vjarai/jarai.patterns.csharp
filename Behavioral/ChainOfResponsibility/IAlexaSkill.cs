namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public interface IAlexaSkill
    {
        bool CanHandleRequest(string request);
        void HandleRequest(string request);
    }
}