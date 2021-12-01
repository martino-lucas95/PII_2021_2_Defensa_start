namespace Ucu.Poo.Defense
{
    public class MaterialType
    {
        public string Name { get; set; }

        public bool IsDangerous { get; set; }

        public MaterialType(string name, bool isDangerous)
        {
            this.Name = name;
            this.IsDangerous = isDangerous;
        }
    }
}