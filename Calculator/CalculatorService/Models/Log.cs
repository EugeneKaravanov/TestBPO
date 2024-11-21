namespace CalculatorService.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }
        public string OperationType { get; set; }
        public bool IsSuccess { get; set; }
    }
}
