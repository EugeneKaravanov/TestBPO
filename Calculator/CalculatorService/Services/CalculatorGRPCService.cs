using Grpc.Core;
using Calculator;
using CalculatorService.Utilities;
using CalculatorService.Models;

namespace CalculatorService.Services
{
    public class CalculatorGRPCService : GRPCService.GRPCServiceBase
    {
        private readonly CalculatorService.Services.CalculatorC _calculator;
        private readonly CalculatorService.Services.LoggerService _loggerService;

        public CalculatorGRPCService(CalculatorC calculator, LoggerService loggerService)
        {
            _calculator = calculator;
            _loggerService = loggerService;
        }

        public override async Task<AnswerGRPC> GetSum(RequestGRPC requestGRPC, ServerCallContext context)
        {
            CalculateResult calculateResult = await _calculator.Sum(requestGRPC.FirstNumber, requestGRPC.SecondNumber);
            AnswerGRPC answerGRPC = Mapper.FormAnswerGRPC(requestGRPC.FirstNumber, requestGRPC.SecondNumber, calculateResult, OperationType.Sum);
            _loggerService.Log(answerGRPC);

            return answerGRPC;
        }

        public override async Task<AnswerGRPC> GetSubtraction(RequestGRPC requestGRPC, ServerCallContext context)
        {
            CalculateResult calculateResult = await _calculator.Subtract(requestGRPC.FirstNumber, requestGRPC.SecondNumber);
            AnswerGRPC answerGRPC = Mapper.FormAnswerGRPC(requestGRPC.FirstNumber, requestGRPC.SecondNumber, calculateResult, OperationType.Substraction);
            _loggerService.Log(answerGRPC);

            return answerGRPC;
        }

        public override async Task<AnswerGRPC> GetMultiplication(RequestGRPC requestGRPC, ServerCallContext context)
        {
            CalculateResult calculateResult = await _calculator.Multiplicat(requestGRPC.FirstNumber, requestGRPC.SecondNumber);
            AnswerGRPC answerGRPC = Mapper.FormAnswerGRPC(requestGRPC.FirstNumber, requestGRPC.SecondNumber, calculateResult, OperationType.Multiplication);
            _loggerService.Log(answerGRPC);

            return answerGRPC;
        }

        public override async Task<AnswerGRPC> GetDivision(RequestGRPC requestGRPC, ServerCallContext context)
        {
            CalculateResult calculateResult = await _calculator.Share(requestGRPC.FirstNumber, requestGRPC.SecondNumber);
            AnswerGRPC answerGRPC = Mapper.FormAnswerGRPC(requestGRPC.FirstNumber, requestGRPC.SecondNumber, calculateResult, OperationType.Division);
            _loggerService.Log(answerGRPC);

            return answerGRPC;
        }

        public override async Task<AnswerGRPC> GetRootExtraction(RequestGRPC requestGRPC, ServerCallContext context)
        {
            CalculateResult calculateResult = await _calculator.CalculateRoot(requestGRPC.FirstNumber, requestGRPC.SecondNumber);
            AnswerGRPC answerGRPC = Mapper.FormAnswerGRPC(requestGRPC.FirstNumber, requestGRPC.SecondNumber, calculateResult, OperationType.RootExtraction);
            _loggerService.Log(answerGRPC);

            return answerGRPC;
        }

        public override async Task<AnswerGRPC> GetExponentiation(RequestGRPC requestGRPC, ServerCallContext context)
        {
            CalculateResult calculateResult = await _calculator.CalculateRoot(requestGRPC.FirstNumber, requestGRPC.SecondNumber);
            AnswerGRPC answerGRPC = Mapper.FormAnswerGRPC(requestGRPC.FirstNumber, requestGRPC.SecondNumber, calculateResult, OperationType.Exponention);
            _loggerService.Log(answerGRPC);

            return answerGRPC;
        }
    }
}
