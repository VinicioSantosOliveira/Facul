// Exercício 5: Classe ConversorTemperatura
// Classe: ConversorTemperatura
// Atributos: temperaturaCelsius
// Método: ConverterParaFahrenheit()
// Descrição: Crie um método que retorne a temperaturaCelsius convertida para Fahrenheit.

class ConversorTemperatura
{
    public int temperaturaCelsius;

    public double converterParaFahrenheit() {
        return (temperaturaCelsius * 1.8) + 32;
    }
}