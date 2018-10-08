using Prism.Mvvm;

namespace XamarinFormsFoundationSolution.ViewModels
{
    public class SampleViewModel : BindableBase
    {
        public string WelcomeMessage { get; set; } = "HelloWorld";

        public SampleViewModel()
        {

        }
    }
}
