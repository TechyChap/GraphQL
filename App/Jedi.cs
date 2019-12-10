using GraphQL.Types;

public class Jedi 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Side { get; set; }
}

//GraphQL Mapping
public class JediType : ObjectGraphType<Jedi>
{
    public JediType()
    {
        Field(x => x.Id);
        Field(x => x.Name, true);
        Field(x => x.Side);
    }
}