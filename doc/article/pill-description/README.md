# Getters and Setters

## Category

Language (C#)

## Description

- Q: Is a property in C# a collection of two methods or is it something else?

- A: The properties in C# are just a collection of two methods: the getter and the setter.

## Recipe

- Create a C# Class Library project.
- Write a field named `field` with two methods: `GetField` and `SetField`.
- Transform the two methods in a property named `Field`.
- Transform the property into an auto-property.
- Compile in release mode and decompile with ILDASM to highlight the two methods (`get_Field` and `set_Field`) automatically created by the compiler.
- Try to manually create the `get_Field` and `set_Field` methods and prove that the compiler will raise an error.