namespace Calculator
{
    public interface IRecord
    {
        void RecordOperations(string operation, double parameters_A, double result);
        void RecordOperations(string operation, double parameters_A, double parameters_B, double result);
    }
}
