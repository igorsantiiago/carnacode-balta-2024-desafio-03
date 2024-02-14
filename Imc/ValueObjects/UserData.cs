namespace Imc.ValueObjects;

public class UserData
{
    public decimal? Height { get; set; }
    public decimal? Weight { get; set; }
    public string Gender { get; set; } = string.Empty;


    public bool ValidateHeight()
    {
        if (!Height.HasValue || Height <= 0)
            return false;

        string? alturaString = Height.ToString();
        if (alturaString!.Contains('.') || alturaString.Contains(','))
            return false;

        return true;
    }

    public decimal? CalculateImc()
    {
        if (Height.HasValue && Weight.HasValue && Height > 0)
        {
            var heightInMeters = Height / 100;
            var imc = Weight / (heightInMeters * heightInMeters);
            return imc;
        }
        return null;
    }
}
