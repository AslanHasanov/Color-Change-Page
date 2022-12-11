namespace DemoApplication.Areas.Client.ViewModels.Colors
{
    public class ColorViewModel
    {
        public ColorViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
