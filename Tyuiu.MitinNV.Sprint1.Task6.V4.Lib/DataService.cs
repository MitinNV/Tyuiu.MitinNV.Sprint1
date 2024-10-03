using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MitinNV.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            var a = value.Split(' ');
            var result = "";
            foreach (var item in a)
            {
                if (item.Contains("нн"))
                {
                    result += " " + item;
                }
            }

            return result.Substring(1);
        }
    }
}
