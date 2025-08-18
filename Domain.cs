namespace code_test;

public class Domain
{
    public int Id { get; set; }
    public string Url { get; set; }

    public override string ToString()
    {
        return "Domain value: " + Id + " " + Url;
    }
}
