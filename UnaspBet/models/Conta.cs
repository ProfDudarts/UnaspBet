namespace Models;
public class Conta
{
    public float Cash;
    public string? Username;

    public Conta(string username)
    {
        this.Username = username;
        this.Cash = 10.0f;
    }

    // public Conta(float initial_cash, string username)
    // {
    //     Username = username;
    //     Cash = 10 + (initial_cash > 0 ? initial_cash : 0);
    // }

    public void depositar(float value)
    {
        Cash += value;
    }

    public void toString(){
        Console.WriteLine($"Usuario: {Username}\nSaldo: {Cash}");
    }
}