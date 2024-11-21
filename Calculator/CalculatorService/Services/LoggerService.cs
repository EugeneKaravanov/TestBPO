using Calculator;
using CalculatorService.Models;
using CalculatorService.Utilities;

namespace CalculatorService.Services
{
    public class LoggerService
    {
        public void Log(AnswerGRPC answerGRPC)
        {
            Log log = Mapper.FormLog(answerGRPC);

        }
    }
}
