# Getters and Setters

## Problem Description

**Do you question the reality?**

Did you ask yourself what is a property in C#? Maybe not. What reason would you have to do that? A property is a property. Just like a field is a field, a method is a method and so on. They are basic elements that we use to create our programs. Right?

**Properties**

But, what if a property is not so basic? What if it is just a syntactic sugar for easier writing two special methods: the getter and the setter for a field?

**Question**

This C# Pill is trying to answer this question:

- Is a property in C# just a collection of two methods?

## Setup

As we know, classes can contain data (as fields) and methods that act on that data.

Let's start by creating a simple field in a class:

```csharp
internal class Class1
{
    public int field = 5;
}
```

### Get and Set Methods

Over the time, programmers decided that it is not a such good idea to publicly expose the fields of the class. Anybody can read and update that data without the class being aware of that. So, the programmers decided to make it private and provide two public methods called setter and getter:

```csharp
internal class Class1_FieldWithMethods
{
    private int field = 5;
    
    public int GetField()
    {
        return field;
    }

    public void SetField(int value)
    {
        field = value;
    }
}
```

This approach has the advantage that the class may perform additional actions whenever the field is read or updated.

This pattern is used in Java.

### The Property

When C# appeared, it decided to provide a custom syntax for writing those two methods.

```csharp
internal class Class2_FieldWithProperty
{
    private int field = 5;

    public int Field
    {
        get
        {
            return field;
        }
        set
        {
            field = value;
        }
    }
}
```

This structure was called a Property.

**Advantages:**

- The two get-set methods are grouped together. Cannot be separated by mistake.
- The signature of the two methods is fixed by the compiler so it is not necessary to explicitly write it. A simple `get` and `set` keywords are sufficient.
- The property can be used just like a field. The syntax is cleaner.

### The Auto-Property

Over the time, the programmers observed that more often then not, a property does not provide additional code in the getters and setters. So, C# provided a cleaner syntax for such a trivial property:

```csharp
internal class Class3_AutoProperty
{
    public int Field { get; set; } = 5;
}
```

**Note**: The previous syntax is still available for the situations when additional actions are needed on the setter and getter, but when there is not such need, the auto-property is more cleaner and easier to write.

## Question

But now we have this question:

- Does a property actually create those two properties behind the scene or it does some other tricks there?

Let's compile in release mode the previous class and look at it with ILDASM.

### Decompile with ILDASM

When decompiled, we can see that, for the properties in `Class2_FieldWithProperty` and `Class3_AutoProperty`, two methods are created:

- `get_Field: int32()`
- `set_Field: void(int32)`

![ILDASM](ildasm-overview.png)

### Manually create the methods

If we try to manually create those two methods while we also have the property, we receive a compilation error.

**Methods**

```csharp
internal class Class3_AutoProperty
{
    public int Field { get; set; } = 5;

    public int get_Field()
    {
        return 0;
    }

    public void set_Field(int value)
    {
    }
}
```

**Compilation error**

![Compilation Error](compilation-error.png)

