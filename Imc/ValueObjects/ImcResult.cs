namespace Imc.ValueObjects;

public class ImcResult
{
    public string Status { get; set; } = string.Empty;
    public string TimeAgoMessage { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime CalculationDate { get; set; }

    public static ImcResult FromImc(decimal? imc)
    {
        var result = new ImcResult
        {
            CalculationDate = DateTime.UtcNow
        };

        if (imc.HasValue)
        {
            if (imc >= 25)
            {
                result.Status = "Sobrepeso ⛔";
                result.Message = "Estamos quase lá! Faça alguns ajustes para ficar no peso ideal!";
            }
            else if (imc >= 18 && imc < 25)
            {
                result.Status = "Peso Ideal ✅";
                result.Message = "Parabéns, você está no seu peso ideal, continue mantendo este estilo!";
            }
            else
            {
                result.Status = "Abaixo do Peso Ideal ⚠️";
                result.Message = "Você está abaixo do peso ideal. Consulte um profissional para orientações.";
            }
        }
        else
        {
            result.Status = "N/A";
            result.Message = "N/A";
        }

        return result;
    }
}
