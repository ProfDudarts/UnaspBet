namespace Models;

public class ContaEspecial : Conta
{
    public float limit;

    public ContaEspecial(string username) : base(username){
        base.Cash = 0f;
        this.limit = 10f;
    }

}