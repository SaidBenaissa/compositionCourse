// Car is tightly coupled to Engine using direct instanciation
// Car car = new Car();

// Car, constructor injection
/* Engine engine = new Engine(); // Create the dependency
Car car = new Car(engine);    // Inject the dependency
car.StartCar();               // Use the Car object
 */

 // Property injection
Car car = new Car();       // Create a Car object
car.Engine = new Engine(); // Inject the dependency, which injection is used here ? 
car.StartCar();            // Use the Car object
