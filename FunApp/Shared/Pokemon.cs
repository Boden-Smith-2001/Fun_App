namespace FunApp.Shared
{
    public class Pokemon
    {

        public Pokemon(int poke_Number, string poke_Name, PokemonType poke_Type, int poke_Health, string region_Found, bool isLegendary)
        {
            this.poke_Number = poke_Number;
            this.poke_Name = poke_Name;
            this.poke_Type = poke_Type;
            this.poke_Health = poke_Health;
            this.region_Found = region_Found;
            this.isLegendary = isLegendary;
        }

        private int poke_Number { get; set; }

        public string poke_Name { get; set; } = "";

        public PokemonType poke_Type { get; set; } = new PokemonType() {Id = 0,  Type = "N/A" };

        public int poke_Health { get; set; }

        public string region_Found { get; set; } = "";

        public bool isLegendary { get; set; } = false;
    }
}