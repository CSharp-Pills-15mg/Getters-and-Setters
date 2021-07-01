namespace GettersAndSetters
{
    internal class Class2_FieldWithProperty
    {
        // C# decided to provide a custom syntax for writing the two methods.

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
}