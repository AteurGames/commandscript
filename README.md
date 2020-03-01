## Commandscript
Commandscript is an esoteric language based solely around commands.

It has many *wondeful* features, including:
* GNU! Can't steal mah stuff!
* No pesky operators! And I mean NONE!
* C#-Based for all you nerds!
* Horribly buggy!
* Not turing complete (yet)!

### Usage/Examples
#### Hello world
```
disp "Hello, World!"
```
#### Variables
```
create myVar "Hello, World!"
```
#### Sub-Commands
```
create toDisplay "Hello from a variable!"
disp < get toDisplay >
```

### Known bugs
* Putting a string with whitespace into a variable will cause an error.
