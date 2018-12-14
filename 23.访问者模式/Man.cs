namespace _23.访问者模式
{
    public class Man : Person
    {

        public override void Accept(Action vistor)
        {
            vistor.GetManConclusion(this);
        }
    }
}