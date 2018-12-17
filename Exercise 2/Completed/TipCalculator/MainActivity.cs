using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
	[Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

        EditText inputBill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;


        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

          
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += CalculateButton_Click;
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            string text = inputBill.Text;
            var bill = double.Parse(text);

            var tip = bill * 0.15;
            var total = bill + tip;

            outputTip.Text = tip.ToString();
            outputTotal.Text = total.ToString();
        }
    }
}