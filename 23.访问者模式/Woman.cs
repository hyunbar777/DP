namespace _23.访问者模式
{
    public class Woman : Person
    {
        public override void Accept(Action vistor)
        {
            vistor.GetWomanConclusion(this);
        }
    }
}