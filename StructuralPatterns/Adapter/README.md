# Adapter

An issue arises when two incompatable
interfaces need to communicate.  
Potentially, one of the interfaces
can be modified for compatability with
the other, but this can involve a lot
of code changes or may be impossible
(e.g. library / CDN code).

The Adapter pattern is a wrapper
that allows incompatable interfaces
to interact with each other.

`Arrays.asList(array)` in Java
is an example use case of the
Adapter Pattern.

Consider the following:

```cs
interface IStudent {}

class UniversityStudent {}
class CollegeStudent : IStudent {}
class SchoolStudent : IStudent {}
```

*Notice how `UniversityStudent` does not*
*implement the `IStudent` Interface.*

If we want a collection of `IStudent`s,
we cannot currently include
`UniversityStudent`s.  
If we wanted to, we could modify
`UniversityStudent` to implement the
interface, but:

- `UniversityStudent` might use different names
  for properties (e.g. `lastname` vs `surname`).
- And we might not have edit access to `UniversityStudent`
  (e.g. if it comes from a library).

Another solution would be to use and Adapter.

```cs
class UniversityStudentAdapter : IStudent
{
    private UniversityStudent uniStudent;

    // e.g.
    public string GetSurname()
    {
        return uniStudent.GetLastName();
    }
}
```
