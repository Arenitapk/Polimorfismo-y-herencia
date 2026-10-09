class Persona
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public int Edad { get; set; }

    public Persona(string name, string lastname, int id, int edad)
    {
        this.Name = name;
        this.LastName = lastname;
        this.Id = id;
        this.Edad = edad;
    }

    public virtual string Presentarse() => $"Mi nombre es: {Name}, mi apellido: {LastName} y mi edad es: {Edad}";
    public string Envejecer() => $"{Name} Has envejecido un año krnal, tu edad: {Edad = Edad + 1}";
}