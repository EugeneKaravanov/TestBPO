using Calculator;
using CalculatorService.Models;

namespace CalculatorService.Utilities
{
    internal class Mapper
    {
        internal static AnswerGRPC FormAnswerGRPC(int firstNumber, int secondNumber, CalculateResult calculateResult, Models.OperationType type)
        {
            AnswerGRPC answerGRPC = new AnswerGRPC();

            answerGRPC.FirstNumber = firstNumber;
            answerGRPC.SecondNumber = secondNumber;
            answerGRPC.Result = calculateResult.Result;
            answerGRPC.Type = TransfertTypeToTypeGRPC(type);
            answerGRPC.IsSuccess = calculateResult.isSuccess;

            if (calculateResult.isSuccess)
            {
                answerGRPC.Message = "Операция прошла успешно";
            }
            else
            {
                answerGRPC.Message = "Не удалось выполнить операцию, проверьте входные параметры";
            }

            return answerGRPC;
        }

        internal static Log FormLog(AnswerGRPC answerGRPC)
        {
            Log log = new Log();

            log.FirstNumber = answerGRPC.FirstNumber;
            log.SecondNumber = answerGRPC.SecondNumber;
            log.Result = answerGRPC.Result;
            log.OperationType = TransfertTypeGRPCToText(answerGRPC.Type);
            log.IsSuccess = answerGRPC.IsSuccess;

            return log;
        }

        private static OperationTypeGRPC TransfertTypeToTypeGRPC(Models.OperationType type)
        {
            switch (type)
            {
                case Models.OperationType.Sum:
                    return OperationTypeGRPC.Sum;

                case Models.OperationType.Substraction:
                    return OperationTypeGRPC.Substraction;

                case Models.OperationType.Multiplication: 
                    return OperationTypeGRPC.Multiplication;

                case Models.OperationType.Division:
                    return OperationTypeGRPC.Division;

                case Models.OperationType.RootExtraction:
                    return OperationTypeGRPC.Rootextraction;

                case Models.OperationType.Exponention:
                    return OperationTypeGRPC.Exponentiation;

                default:
                    return OperationTypeGRPC.Unknown;
            }
        }

        private static string TransfertTypeGRPCToText(OperationTypeGRPC type)
        {
            switch (type)
            {
                case OperationTypeGRPC.Sum:
                    return "Сложение";

                case OperationTypeGRPC.Substraction:
                    return "Вычитание";

                case OperationTypeGRPC.Multiplication:
                    return "Умножение";

                case OperationTypeGRPC.Division:
                    return "Деление";

                case OperationTypeGRPC.Rootextraction:
                    return "Вычисление корня";

                case OperationTypeGRPC.Exponentiation:
                    return "Возведение в степень";

                default:
                    return "Неизвестно";
            }
        }
    }
}
