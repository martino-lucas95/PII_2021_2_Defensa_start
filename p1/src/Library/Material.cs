namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public bool IsDangerous { get; set; }

        public Material(string name, MaterialType type, bool isDangerous)
        {
            this.Name = name;
            this.Type = type;
            this.IsDangerous = isDangerous;
        }
    }
}