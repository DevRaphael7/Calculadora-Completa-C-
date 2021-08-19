using System;

public class Calculadora
{
	public String TextDown;
	public String TextUp;
    public string resultado;
    public string operacao;

	public void atualizarDisplay(String numero)
    {
        if(TextDown == "0")
        {
            TextDown = "";
        }
        this.TextDown += numero;
        resultado = this.TextDown.ToString();

    }

    public void operacaoAri(string escolhaDaOperacao)
    {
        this.operacao = escolhaDaOperacao;
        computador();
    }
	public void computador()
    {
        double numDown = double.Parse(TextDown);
        double numUp = double.Parse(TextUp);
        double resultadoDaOperacao = 0;

        switch (operacao)
        {
            case "+":
                resultadoDaOperacao = numDown + numUp;
            break;
            case "-":
                if(numUp == 0)
                {
                    numUp = numDown;
                    numDown = 0;
                    resultadoDaOperacao = numUp;
                    break;
                }
                resultadoDaOperacao = numUp - numDown;
            break;
            case "*":
                if(numUp == 0)
                {
                    resultadoDaOperacao = numDown;
                    break;
                }
                resultadoDaOperacao = numDown * numUp;
            break;
            case "%":
                if (numUp == 0)
                {
                    resultadoDaOperacao = numDown;
                    numDown = 0;
                }
                resultadoDaOperacao = numUp / numDown;
            break;
        }
        TextUp = resultadoDaOperacao.ToString();
        TextDown = "0";
        numUp = 0;
        numDown = 0;
    }

    public void Limpar()
    {
        TextDown = "0";
        TextUp = "0";
        resultado = "0";
    }

    public Calculadora()
    {
        this.TextDown = "0";
        this.TextUp = "0";
        this.resultado = "0";
        this.operacao = "";
    }
}
