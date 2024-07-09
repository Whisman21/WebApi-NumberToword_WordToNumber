using NumberToWors_WordToNumber;
using NumberToWord_WordToNumber.NewFolder;
namespace NumberToWord_WordToNumber.Resources
{
    public class convert
    {

        public string convertn(INPUT n)
        {
            converter converter = new converter();
            Input input = new Input(n.value);
            Output output = converter.Result(input);

            string result = output.GetResult();
            return result;
        }

        public dynamic convertw(INPUT n)
        {
            converter converter = new converter();
            InputWN inputwn = new InputWN(n.value);
            Output outputwn = converter.ResultWN(inputwn);


            dynamic result = outputwn.GetResult();
            return result;
        }



    }
}
