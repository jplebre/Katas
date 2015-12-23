# Katas
A solution that contains several attempts at Katas.  
I wanted to place several katas and several attempts at them inside the same solution so I could easily navigate through them.  
Maybe it's a mistake, but I'll figure it out as I go :)  

## How To:
Ensure you get the NuGet Packages.  
Some katas use SpecFlow (new job uses it, so I am doing some Katas to help me learn SpecFlow) so ensure you install SpecFlow tool.  

Inside the VS solution you'll see solution folders for each Kata attempt. The name space reflects this:

`Kata.KataName.Technology/Technique_of_focus.AttemptNumber`

You can enable/disable a kata by rightclicking on the solution folder and selecting "Load/Unload Projects".  


## Poor Man Dependency Injection
This was really really helpful to me: http://blog.robbowley.net/2010/01/18/not-so-poor-mans-dependency-injection/
It looks very ugly, but this would allow you to test your classes' dependencies if you don't have a proper IoC in place. If this was production, you could delete the default constructor and use a proper IoC manager.

This technique is also helpful if you have a legacy code that you wish to start testing and adding the dependencies.

## External packages used:
- RhinoMocks
- NUnit
- Specflow


## Notes on the Fibonacci Kata
While working on this kata I found out that WHERE you start your TDD journey matters a lot. It becomes a lot harder to later on change your program (and your tests) to improve performance. 
On the specific example of the Fibonacci sequence as a kata, where you start TDDing might mean that you have a good performing generator, or a design that relies on recursion (which makes it unuseable for longer Fibonacci sequences).

Why does this matter? Because at this point I found it really hard to refactor without changing the methods' signatures. It is possible (as you can see if you follow the commit's order) but doesn't make much "sense"

Bottom line here is:
- Don't be afraid to change tests. User helper methods if you prefer, making it easier to change several tests relying on the same method call
- Do think about how and were you start approaching a test driven development design approach
