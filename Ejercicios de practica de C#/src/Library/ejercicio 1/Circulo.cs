namespace Library;

public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double GetPerimeter()
    {
        double resultado;
        resultado = (2 * 3.14) * this.radio;
        return resultado;
    }

        public double GetArea()
    {
        double resultado;
        resultado = 3.14 * (this.radio * 2);
        return resultado;
    }
}