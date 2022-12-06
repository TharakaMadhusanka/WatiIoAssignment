
namespace WatiO.Shared
{
    public class SharedClass
    {
        public int Sum(NumbersModel numbersModel )
        {
            return numbersModel.Number1 + numbersModel.Number2;
        }
    }

    public class NumbersModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

    }
}