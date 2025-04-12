public class Car
{
    // Composition: Direct injection of dependency (Tightly Coupled) 
    // private Engine _engine = new Engine(); // tightly coupled

    
    // Composition: Constructor injection (Loosly cooupled)
    // private Engine _engine;
    // public Car(Engine engine) // Constructor injection (Loosely Coupled)
    // { 
    //     _engine = engine;
    // }

    // Property Injection
    public Engine? Engine{
        private get;
        set; // Property injection (Loosely Coupled) need setter to be public
    }

    public void StartCar()
    {
        if (Engine == null)
        {
            throw new InvalidOperationException("Engine not set.");
        }
        Engine.Start();
    }
}
