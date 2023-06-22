# Mediator

Consider an air traffic control system.
If 3 planes are trying to land on the
same runway, they must coordinate with
each other.  
If 15 planes are trying to land on the
same runway, each would have to
communicate with 14 others. Plus, if a
16th comes along, 15 new communication
channels must be opened.  
This can be extremely dangerous, because
it's difficult for everyone to stay in
sync.

Instead, airports have an air traffic
control tower that all planes
communicate with. The air traffic
controller's sole purpose is coordination,
coordination is much more likely to be
achieved safely.  
If another plane wants to land, only
1 more connection must be made, rather
than n (where n is the number of planes
already trying to land).

The air traffic control tower acts
as the Mediator in the Mediator Design
Pattern.

Specifically, the Mediator Design Pattern
defines how a set of other objects
interact with each other.  
Direct communication between objects in
restricted in favour of all objects
communicating through the mediator.
