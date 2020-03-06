## Commandscript
[![PRs Welcome](http://img.shields.io/badge/PRs-welcome-brightgreen)](http://makeapullrequest.com)

Commandscript is an esoteric language based solely around commands.

It has many *wonderful* features, including:
* GNU! Can't steal mah stuff!
* No pesky operators! And I mean NONE!
* C#-Based for all you nerds!
* Horribly buggy!
* Not turing complete (yet)!

### Usage/Examples
#### Hello world
```cs
disp 'Hello, World!'
```
#### Variables
```cs
create myVar 'Hello, World!'
```
#### Sub-Commands
```cs
create toDisplay 'Hello from a variable!'
disp < get toDisplay >
```
### Dictionary (Coming soon)
```cs
dic_create greets

dic_set greets english 'hello'
dic_set greets spanish 'hola'

disp < dic_get greets english >
```

### Known bugs
* Putting a string with whitespace into a variable will cause an error.
