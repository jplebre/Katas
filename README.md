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
