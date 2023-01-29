
namespace LargeString.Abstractions
{
    public class Result
    {
        public char Letter { get; set; }
        public int Length { get; set; } = 0;

        public override string ToString()
        {
            var str = "";
            for(var i = 0; i < Length; i++)
            {
                if(i != 0)
                {
                    str += ", ";
                }
                str += $"{Letter}";
            }
            return str;
        }
    }
}
