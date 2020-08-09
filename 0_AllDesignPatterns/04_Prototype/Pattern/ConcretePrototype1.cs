namespace _04_Prototype.Pattern
{
    class ConcretePrototype1 : AbstractPrototype
    {
        public ConcretePrototype1(int Id) : base(Id)
        {
        }

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}
