using Calculator;
using GatewayService.Models;

namespace GatewayService.Utilities
{
    internal class Mapper
    {
        internal static RequestGRPC TransferRequestDtoToRequestGRPC(int firstNumber, int secondNumber)
        {
            RequestGRPC requestGRPC = new RequestGRPC();

            requestGRPC.FirstNumber = firstNumber;
            requestGRPC.SecondNumber = secondNumber;

            return requestGRPC;
        }

        internal static AnswerDto TransferAnswerGRPCToAnswerDto(AnswerGRPC answerGRPC)
        {
            AnswerDto answerDto = new AnswerDto();

            answerDto.FirstNumber = answerGRPC.FirstNumber;
            answerDto.SecondNumber = answerGRPC.SecondNumber;
            answerDto.Result = answerGRPC.Result;
            answerDto.IsSuccess = answerGRPC.IsSuccess;
            answerDto.OperationType = TransfertTypeGRPCToType(answerGRPC.Type);
            answerDto.Message = answerGRPC.Message;

            return answerDto;
        }

        private static OperationType TransfertTypeGRPCToType(OperationTypeGRPC type)
        {
            switch (type)
            {
                case OperationTypeGRPC.Sum:
                    return OperationType.Sum;

                case OperationTypeGRPC.Substraction:
                    return OperationType.Substraction;

                case OperationTypeGRPC.Multiplication:
                    return OperationType.Multiplication;

                case OperationTypeGRPC.Division:
                    return OperationType.Division;

                case OperationTypeGRPC.Rootextraction:
                    return OperationType.RootExtraction;

                case OperationTypeGRPC.Exponentiation:
                    return OperationType.Exponention;

                default:
                    return OperationType.Unknown;
            }
        }
    }
}
