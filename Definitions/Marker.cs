namespace Definitions
{
#pragma warning disable CS8618

    public delegate dynamic Transform(dynamic arg);

    public class Marker : Primitive
    {
        public static readonly Transform EmptyTransform = x => x;
        
        public dynamic? Argument;
        public dynamic? Transform = EmptyTransform;

        public override dynamic? Read() => Argument;

        public override void Write(dynamic? x)
        {
            Transform = x ?? EmptyTransform;
        }

        internal Marker() : base()
        {
        }

        public void Draw(dynamic? previous = null, dynamic? next = null)
        {
            Argument = previous?.Read();

            Argument = Transform(Argument);

            if (previous?.Equals(next) ?? false) throw new Exception();

            next?.Write(Argument);
        }
    }
}
