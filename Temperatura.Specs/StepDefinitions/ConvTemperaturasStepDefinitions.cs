namespace Temperatura.Specs.StepDefinitions;

[Binding]
public sealed class ConvTemperaturasStepDefinitions
{
    private double _temperaturaFahrenheit;
    private double _temperaturaCelsius;
    private double _temperaturaKelvin;

    [Given("que o valor da temperatura � de (.*) graus Fahrenheit")]
    public void PreencherTemperaturaFahrenheit(double valorFahrenheit)
    {
        _temperaturaFahrenheit = valorFahrenheit;
    }

    [When("eu solicitar a convers�o desta teperatura")]
    public void ProcessarConversao()
    {
        _temperaturaCelsius =
            ConversorTemperatura.FahrenheitParaCelsius(
                _temperaturaFahrenheit);
        _temperaturaKelvin =
            ConversorTemperatura.FahrenheitParaKelvin(
                _temperaturaFahrenheit);
    }

    [Then("o resultado da convers�o para Celsius ser� de (.*) graus")]
    public void ValidarResultadoCelsius(double valorCelsius)
    {
        _temperaturaCelsius.Should().Be(valorCelsius);
    }

    [Then("o resultado da convers�o para Kelvin ser� de (.*) graus")]
    public void ValidarResultadoKelvin(double valorKelvin)
    {
        _temperaturaKelvin.Should().Be(valorKelvin);
    }
}