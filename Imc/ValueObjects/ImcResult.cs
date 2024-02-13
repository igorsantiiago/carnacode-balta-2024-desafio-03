namespace Imc.ValueObjects;

public class ImcResult
{
    public string Status { get; set; } = string.Empty;
    public string DateDescription { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime CalculationDate { get; set; }
}
