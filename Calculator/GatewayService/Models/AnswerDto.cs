using Microsoft.OpenApi.Models;

namespace GatewayService.Models
{
    public class AnswerDto
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result {  get; set; }
        public OperationType OperationType { get; set; }
        public bool IsSuccess {  get; set; }
        public string Message {  get; set; }
    }
}
