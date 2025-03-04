using System;

class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        currentState = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void KunciPintu()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }
}
class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}
