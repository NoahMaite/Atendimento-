using System.Collections.Generic;

public class Guiche
{
    private int id;
    private Queue<Senha> atendimentos;

    public Guiche()
    {
        atendimentos = new Queue<Senha>();
        id = 0;
    }

    public Guiche(int id)
    {
        atendimentos = new Queue<Senha>();
        this.id = id;
    }

    public bool Chamar(Queue<Senha> filaSenhas)
    {
        if (filaSenhas.Count > 0)
        {
            Senha s = filaSenhas.Dequeue();
            s.RegistrarAtendimento();
            atendimentos.Enqueue(s);
            return true;
        }
        return false;
    }

    public Queue<Senha> GetAtendimentos()
    {
        return atendimentos;
    }
}
