# Abstract Factory

The Abstract Factory should be
used when you have multiple
families of related products.  
e.g. Manufacturers for Computer
parts.

`Manufacturer` would be an Abstract Factory.  
`Manufacturer`s should implement `createCPU()` and `createGPU()` methods that using the interfaces `ICPU` and `IGPU` respectively.

`Intel` and `AMD` would be Concrete Factories.  
`Intel` would return an `IntelCPU` and an `IntelGPU` from the methods.  
`AMD` would return an `AMDCPU` and an `AMDGPU` from the methods.

Methods in the client could then create a new `ICPU` or `IGPU`
without needing to know what `Manufacturer` they have been given.

```cs
public static void CreateComponents(Manufacturer m)
{
    ICPU cpu = m.createCPU();
    IGPU gpu = m.createGPU();
}
```

This method works when supplied an `Intel` object or an `AMD` object.