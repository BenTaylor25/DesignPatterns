# Bridge

The bridge pattern splits a
two-dimensional class structure
into two one-dimensional class
structures that are joined together.

Consider the following classes:

```
PetrolCar
PetrolMotorcycle
PetrolTruck

ElectricCar
ElectricMotorcyle
ElectricTruck
```

This set of classes has two seperate
identities: Petrol/Electric, and
Car/Motorcycle/Truck.

If we want to add another energy type
(e.g. Diesel), we would need to create
three new classes (`DieselCar`,
`DieselMotorcycle`, `DieselTruck`).  
Similarly, if we want to add another
vehicle type, we would need to create
one for each energy type (`PetrolTractor`,
`ElectricTractor`, `DieselTractor`).

What we want to do instead is define
each of our energy types seperately
from our vehicle types.  
We can then join one of each together
using composition.  
This means that if we want to add another
energy type, we would only need to create
one new class for full compatability.
