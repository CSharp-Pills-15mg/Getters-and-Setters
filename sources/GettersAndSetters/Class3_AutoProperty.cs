namespace GettersAndSetters
{
    internal class Class3_AutoProperty
    {
        // Later, C# provided a condensed syntax for writing trivial properties.
        // Properties that does not provide any additional functionality on the getter and setter methods.

        public int Field { get; set; } = 5;

        public int get_Field()
        {
            return 0;
        }

        public void set_Field(int value)
        {
        }
    }
}