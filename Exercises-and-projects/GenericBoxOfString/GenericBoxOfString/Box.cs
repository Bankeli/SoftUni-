namespace GenericBoxOfString
{
    public class Box<T>
    {

        public T Value { get; set; }
        public Box(T value)
        { 
            this.Value = value;

        }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
    }
}
