# Proxy

The Proxy Design Pattern is basically
the same as a Proxy Server.  
Benefits include access control and caching.

The Proxy class and the actual Service itself
should implement the same interface so that
the client can use either interchangeably.

If class A wants to access something
from class B, but can only access
it through proxy class P, P can
restrict A's access, without restricting
any other class's access to B.
