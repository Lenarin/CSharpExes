using Ex1_Strategy.Greeting;

namespace Ex1_Strategy.Character
{
    public class Cow: Character
    {
        public Cow() : base(greetingBehaviour: new MooGreeting())
        {
            
        }
    }
}