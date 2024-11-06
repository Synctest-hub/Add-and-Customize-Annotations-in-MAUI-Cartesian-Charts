namespace AnnotationSample
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public string? Month { get; set; }
        public double Temperature { get; set; }
    }

    public class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Model>()
        {
            new Model { Month = "Jan", Temperature = 37 },
            new Model { Month = "Mar", Temperature = 39 },
            new Model { Month = "May", Temperature = 48 },
            new Model { Month = "Jul", Temperature = 57 },
            new Model { Month = "Sep", Temperature = 54 },
            new Model { Month = "Nov", Temperature = 43 }
        };
        }
    }
}
