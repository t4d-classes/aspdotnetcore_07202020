# Exercise 2

1. Create a new service named `CarsDataService` in the `Services` folder.

2. Add a new method named `All` which returns a collection of Car models. Within the service hard code an array of two car models using the following code in the class' constructor. A `Car` model will be needed to complete this step, add the model to the `Models` folder in the `Shared` project. Also, declare the `Id` member to be a `long` instead of an `int`.

```csharp
this._cars = new List<Car>();
cars.Add(new Car() {
    Id = 1, Make = "Mazda", Model = "Miatta", Year = 2015, Color = "red", Price = 50000
});
cars.Add(new Car() {
    Id = 1, Make = "Ford", Model = "Fusion Hybrid", Year = 2018, Color = "blue", Price = 45000
});
```

3. Using the Cars service, display a table of cars within the `main` HTML element. Show a column for each field, and be sure to display appropriate column headers.

Hint: How are services made available within a Razor page?

Hint: What lifecycle method do we use to initialize variables within a page?