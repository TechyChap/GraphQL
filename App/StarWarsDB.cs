using System.Collections.Generic;

//A dummy "persistent store" for all your favourite Jedi characters
public class StarWarsDB {
    public IEnumerable<Jedi> GetJedis() 
    {
        return new List<Jedi>() {
            new Jedi(){ Id = 1, Name ="Luke", Side="Light"},
            new Jedi(){ Id = 2 ,Name ="Yoda", Side="Light"},
            new Jedi(){ Id = 3, Name ="Darth Vader", Side="Dark"}
        };
    }

}
