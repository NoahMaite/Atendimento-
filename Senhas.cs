using System.Collections.Generic;

public class Senhas
{
    private int proximoAtendimento;
    private Queue<Senha> filaSenhas;

    public Senhas()
    {
        filaSenhas = new Queue<Senha>();
        proximoAtendimento = 1;
    }

    public void Gerar()
    {
        Senha s = new Senha(proximoAtendimento);
        filaSenhas.Enqueue(s);
        proximoAtendimento++;
    }

    public Queue<Senha> GetFila()
    {
        return filaSenhas;
    }
}
