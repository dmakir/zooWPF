namespace WPFZOOMVVM
{
    public interface IAnimal
    {
        float Height { get; set; }
        float Weight { get; set; }
        string EyeColor { get; set; }
        string Sound();

    }
}