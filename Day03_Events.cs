using System;

namespace PracticePrograms
{
    // Delegate defines the signature of the method the event will call.
    // This makes the event strongly typed and ensures all subscribers follow the same pattern.
    public delegate void TemperatureChangedHandler(double newTemp);

    // This class acts as the event publisher
    public class Thermometer
    {
        private double _temperature;

        // 'event' is built on top of delegate
        // Only the class that declares the event can invoke it
        // It enforces encapsulation and prevents misuse by outside classes
        public event TemperatureChangedHandler? OnTemperatureChanged;

        public void SetTemperature(double temp)
        {
            if (temp != _temperature)
            {
                _temperature = temp;
                Console.WriteLine($"Temperature set to {temp}°C");

                // Event is triggered (if there are any subscribers)
                // This is where all subscriber methods are called automatically
                OnTemperatureChanged?.Invoke(temp);
            }
        }
    }

    // This class acts as an event subscriber
    // It registers a method to be called when the event is raised
    public class AlarmSystem
    {
        public void Alert(double temp)
        {
            if (temp > 50)
                Console.WriteLine("Alert: Overheat detected");
            else
                Console.WriteLine("Temperature within safe range");
        }
    }

    public static class Day03_Events
    {
        public static void Run()
        {
            Console.WriteLine("Day 3 - Events based on Delegates");
            Console.WriteLine();

            Thermometer sensor = new Thermometer();
            AlarmSystem alarm = new AlarmSystem();

            // Subscribing the Alert method to the event
            // Whenever temperature changes, Alert will be called
            sensor.OnTemperatureChanged += alarm.Alert;

            // Changing temperature
            sensor.SetTemperature(45);  // Normal condition
            sensor.SetTemperature(60);  // Will trigger alert
        }
    }
}
//Notes:
/*
What are Events:
- Events are built on top of delegates and follow the publish-subscribe model.
- Used to notify one or many subscribers that something has happened.

Why Use Events:
- Loose coupling: The publisher does not need to know who is listening.
- Encapsulation: Only the publisher can raise the event.
- Scalability: Multiple parts of the system can listen and react independently.

When to Use:
- Any scenario where you want to trigger actions in other parts of the system based on some change or event.

Examples in real-world projects:
- UI: Button click, key press
- SCADA/PLC: Tag value changed
- Logging: Log written, error raised
- Messaging: Email/SMS sent after user signup
- Monitoring: Sensor crossed threshold, system health event

Difference between Delegate and Event:
- Delegate is just a pointer to a method.
- Event is a controlled delegate that only the declaring class can raise.
- Subscribers use +=, but only the publisher can invoke it.

Important:
- If no subscribers, the event remains null — always use null-conditional check before invoking: OnSomething?.Invoke()

Best Practice:
- Always follow EventHandler pattern in public APIs for flexibility.
- Use Action<T> or EventHandler<T> for consistency.
*/