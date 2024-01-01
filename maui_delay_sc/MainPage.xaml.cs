namespace maui_delay_sc
{
    public partial class MainPage : ContentPage
    {        

       
        public MainPage()
        {
            InitializeComponent();                        

            _ = NavigateWithDelay();
        }

        

        public async Task NavigateWithDelay()
        {
            Console.WriteLine("In the running here ..");

            try
            {
                await Task.Delay(4000);
                
                await Shell.Current.GoToAsync("///NewPage1");
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine(ex.Message);
            }

        }


    }

}
