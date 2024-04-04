namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Percentage15Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 15;
        }

        private void Percentage30Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 30;
        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            double amountValue = Convert.ToDouble(ValueEntry.Text);
            double tipPercentage = TipPercentageSlider.Value / 100;
            double tipValue = amountValue * tipPercentage;

            tipValue = Math.Floor(tipValue);
            double totalAmount = tipValue + amountValue;

            TotalLabel.Text = totalAmount.ToString();
            TipLabel.Text = tipValue.ToString();
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OnTipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double sliderValue = TipPercentageSlider.Value;
            TipPercentageLabel.Text = sliderValue.ToString() + "%"; 
        }
    }

}
