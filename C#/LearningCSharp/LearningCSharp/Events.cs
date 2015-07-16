using System;

/*  10. EVENTS */

/*  An event is a way for a class to notify the users of an object when something of interest happens to the object.
    The object that raises the event is called the "publisher" or "sender" of the event.
    Another class may listen or "subscribe" to this event and respond accordingly.
*/

namespace Events
{
    /*  In C#, events are members of the Publisher class.
        To subscribe to an event, an event handler is (literally) added to the event.
        Eg: window.ClickedEvent += MyEventHandler;
    */

    public delegate void MyEventHandler();

    public class Example
    {
        public event MyEventHandler TriggerIt;

        public void Trigger()
        {
            TriggerIt();
        }

        public void Hello()
        {
            Console.WriteLine("Hello!");
        }

        public void WhatsUp()
        {
            Console.WriteLine("What's up");
        }

        public void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }

        public static void Main()
        {
            Example testEvent = new Example();

            // Subscribe to the event by associating handlers with the event
            testEvent.TriggerIt += new MyEventHandler(testEvent.Hello);
            testEvent.TriggerIt += new MyEventHandler(testEvent.WhatsUp);
            testEvent.TriggerIt += new MyEventHandler(testEvent.Goodbye);
            // Trigger the event:
            testEvent.Trigger();

            // Unsubscribe from the event by removing the handler from the event
            testEvent.TriggerIt -= new MyEventHandler(testEvent.WhatsUp);
            Console.WriteLine("\"What\'s Up\" has unsubscribed from the event");

            testEvent.Trigger();
        }
    }
}