# Getters and Setters

## Preparation Recipe

### Property Evolution

- Create a C# Class Library project.

- (1) Write a public field named `number`.

  ```csharp
  public class Class1
  {
      private int number = 5;
  }
  ```

- (2) Add two methods: `GetNumber` and `SetNumber`.

  ```csharp
  public class Class2
  {
      private int number = 5;
  
      public int GetNumber()
      {
          return number;
      }
  
      public void SetNumber(int value)
      {
          number = value;
      }
  }
  ```

- (3) Transform the two methods into a property named `Number`.

  ```csharp
  public class Class3
  {
      private int number = 5;
  
      public int Number
      {
          get
          {
              return number;
          }
          set
          {
              number = value;
          }
      }
  }
  ```

- (4) Transform the property into an auto-property.

  ```csharp
  public class Class4
  {
      public int Number { get; set; } = 5;
  }
  ```

- (5) Use lambda expressions

  ```csharp
  public class Class5
  {
      private int number = 5;
  
      public int Number
      {
          get => number;
          set => number = value;
      }
  }
  ```

- Compile in release mode and decompile with ILDASM to highlight the two methods (`get_Field` and `set_Field`) automatically created by the compiler.

- Try to manually create the `get_Field` and `set_Field` methods and prove that the compiler will raise an error.

- Ask about advantages and disadvantages of using properties:

  - Advantages

    - Less code to write with same result, including information expressed by the code.
    - Can add properties in interfaces.

        ```csharp
        public interface IClass4
        {
            int Number { get; set; }
        }
        ```
    
  - Disadvantages

    - No encapsulation

### Encapsulation of the field vs encapsulation of the data:

```csharp
public class MyCoolNumber
{
    private int number = 5;

    public void Increment()
    {
        number++;
    }

    public void Add(int value)
    {
        number += value;
    }

    public override string ToString()
    {
        return number.ToString();
    }

    public static implicit operator int(MyCoolNumber myCoolNumber)
    {
        return myCoolNumber.number;
    }
}
```

### Init-only properties

- Talk about the init-only properties.
  - The need was to create read-only properties and still use the object initialization pattern.

