class Aprendiz : Persona
{
    public string Program { get; set; }
    public int Ficha { get; set; }

    public Aprendiz(string AName, string Alastname, int Aid, int Aedad, string program, int ficha) : base(AName, Alastname, Aid, Aedad)
    {
        this.Program = program;
        this.Ficha = ficha;
    }
    public override string Presentarse() => $"Soy un aprendiz y mi nombre es: {Name} y mi programa es: {Program} y mi edad es {Edad}";
}