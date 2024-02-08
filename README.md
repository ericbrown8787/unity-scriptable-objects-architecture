# Engineering Pillars

## Modular

- Systems are not directly dependent on each other.

- Scenes as clean slates. Minimize DontDestroyOnLoad objects. 

- Prefabs are self-contained(In whatever scene they're placed in)

- Use components.

## Editable

- Focus on data

- Make it possible to change the game without changing code

- Emergent design(Allow designers to rearrange things easily)

- Allow changing values at runtime

## Debuggable

- Test in isolation(Modularity)

- Debug views and features

- Never fix a bug you don't understand


# ScriptableObject

- Serializable Unity class

- Similar to MonoBehaviour, with no transform

- Saved as a .asset file(This is not necessary, you can just interact with them in memory)


## Simple Use Cases

- Game config file

- Inventory

- Enemy stats


# Architecture

## Singletons are the root of all evil. 

- Rigid connections/not modular

- No polymorphism

- Not testable

- Dependency nightmare(Sometimes difficult to separate desired peristent items from undesired)

- Race conditions likely

### Solutions

- Reduce need for global managers

- Inversion of control

- -Example: Dependency injection

- -Objects are *given* dependencies


# Event Architecture

- Modularize Systems

 - Reuse in other projects
	
 - Isolates prefabs
	
 - Bindings between objects in your game can be events

- Optimize: Only execute when needed.


# Runtime Sets

- Implementation of the Set data structure as a scriptable object

- Keep track of a list of objects in a scene

- Avoid race conditions

- More flexible than Unity tags, singleton

# Enums

- Must change in code

- Work best for lists that aren't likely to change

- Difficult to remove/reorder

- Can't hold additional data

# Asset based systems 

## Generic Systems

- System is ScriptableObject Asset in projects

- Reference directly with inspector

- No code lookup

- No scene-only references

## Inventory

- ScriptableObject Master List

- ScriptableObject per item


# Questions:
- What is dependency injection? Is it just a system for passing object references? Where might have we used it in Unity?

- What situations are enums best suited for? When should I not use them? Ryan Hipple mentions enums existing in a set order, but I've never actually needed to refer to an enum by an index before, so I'm not sure what situations being able to do that would be useful in. 


# Test Bed Repo:
https://github.com/ericbrown8787/unity-scriptable-objects-architecture

Not much here yet, but I'd like to try working with some of the classes he described. 
