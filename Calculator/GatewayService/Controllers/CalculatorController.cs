using Calculator;
using GatewayService.Models;
using GatewayService.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace GatewayService.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly Calculator.GRPCService.GRPCServiceClient _grpcServiceClient;

        public CalculatorController(Calculator.GRPCService.GRPCServiceClient grpcServiceClient)
        {
            _grpcServiceClient = grpcServiceClient;
        }

        [HttpGet("sum/{firstNumber:int}/{secondNumber:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSum(int firstNumber, int secondNumber, CancellationToken cancellationToken)
        {
            AnswerDto answerDto = new AnswerDto();     
            RequestGRPC requestGRPC = Mapper.TransferRequestDtoToRequestGRPC(firstNumber, secondNumber);
            AnswerGRPC answerGRPC = await _grpcServiceClient.GetSumAsync(requestGRPC, cancellationToken: cancellationToken);
            answerDto = Mapper.TransferAnswerGRPCToAnswerDto(answerGRPC);

            return Ok(answerDto);
        }

        [HttpGet("subtraction/{firstNumber:int}/{secondNumber:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetSubtraction(int firstNumber, int secondNumber, CancellationToken cancellationToken)
        {
            AnswerDto answerDto = new AnswerDto();
            RequestGRPC requestGRPC = Mapper.TransferRequestDtoToRequestGRPC(firstNumber, secondNumber);
            AnswerGRPC answerGRPC = await _grpcServiceClient.GetSubtractionAsync(requestGRPC, cancellationToken: cancellationToken);
            answerDto = Mapper.TransferAnswerGRPCToAnswerDto(answerGRPC);

            return Ok(answerDto);
        }

        [HttpGet("multiplication/{firstNumber:int}/{secondNumber:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetMultiplication(int firstNumber, int secondNumber, CancellationToken cancellationToken)
        {
            AnswerDto answerDto = new AnswerDto();
            RequestGRPC requestGRPC = Mapper.TransferRequestDtoToRequestGRPC(firstNumber, secondNumber);
            AnswerGRPC answerGRPC = await _grpcServiceClient.GetMultiplicationAsync(requestGRPC, cancellationToken: cancellationToken);
            answerDto = Mapper.TransferAnswerGRPCToAnswerDto(answerGRPC);

            return Ok(answerDto);
        }

        [HttpGet("division/{firstNumber:int}/{secondNumber:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetDivision(int firstNumber, int secondNumber, CancellationToken cancellationToken)
        {
            AnswerDto answerDto = new AnswerDto();
            RequestGRPC requestGRPC = Mapper.TransferRequestDtoToRequestGRPC(firstNumber, secondNumber);
            AnswerGRPC answerGRPC = await _grpcServiceClient.GetDivisionAsync(requestGRPC, cancellationToken: cancellationToken);
            answerDto = Mapper.TransferAnswerGRPCToAnswerDto(answerGRPC);

            if (answerDto.IsSuccess)
                return Ok(answerDto);
            else
                return BadRequest(answerDto);
        }

        [HttpGet("rootExtraction/{firstNumber:int}/{secondNumber:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRootExtraction(int firstNumber, int secondNumber, CancellationToken cancellationToken)
        {
            AnswerDto answerDto = new AnswerDto();
            RequestGRPC requestGRPC = Mapper.TransferRequestDtoToRequestGRPC(firstNumber, secondNumber);
            AnswerGRPC answerGRPC = await _grpcServiceClient.GetRootExtractionAsync(requestGRPC, cancellationToken: cancellationToken);
            answerDto = Mapper.TransferAnswerGRPCToAnswerDto(answerGRPC);

            if (answerDto.IsSuccess)
                return Ok(answerDto);
            else
                return BadRequest(answerDto);
        }

        [HttpGet("exponentiation/{firstNumber:int}/{secondNumber:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetExponentiation(int firstNumber, int secondNumber, CancellationToken cancellationToken)
        {
            AnswerDto answerDto = new AnswerDto();
            RequestGRPC requestGRPC = Mapper.TransferRequestDtoToRequestGRPC(firstNumber, secondNumber);
            AnswerGRPC answerGRPC = await _grpcServiceClient.GetExponentiationAsync(requestGRPC, cancellationToken: cancellationToken);
            answerDto = Mapper.TransferAnswerGRPCToAnswerDto(answerGRPC);

            if (answerDto.IsSuccess)
                return Ok(answerDto);
            else
                return BadRequest(answerDto);
        }
    }
}
