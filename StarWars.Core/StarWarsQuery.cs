using GraphQL.Types;

namespace StarWars.Core
{
    public class StarWarsQuery : ObjectGraphType
    {
        public StarWarsQuery()
        {
            Field<DroidType>(
                "hero",
                resolve: context => new Droid {Id = 1, Name = "R2D2"}
            );
        }
    }
}