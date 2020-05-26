using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Jjoe64.Graphview;
using System.ComponentModel;
using Com.Jjoe64.Graphview.Series;
using Java.Lang;

namespace XamarinNativeAndroidGraphView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private GraphView graphView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            graphView = FindViewById<GraphView>(Resource.Id.graphView);

            scalingXY();
        }

        private void scalingXY()
        {
            DataPoint[] points = new DataPoint[100];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new DataPoint(i, Math.Sin(i * 0.5) * 20 * (Math.Random() * 10 + 1));
            }

            LineGraphSeries series = new LineGraphSeries(points);

            // set manual X bounds
            graphView.Viewport.YAxisBoundsManual = true;
            graphView.Viewport.SetMinY(-150);
            graphView.Viewport.SetMaxY(150);

            graphView.Viewport.XAxisBoundsManual = true;
            graphView.Viewport.SetMinX(4);
            graphView.Viewport.SetMaxX(80);

            // enable scaling
            graphView.Viewport.Scalable = true;
            graphView.Viewport.SetScalableY(true);

            series.Title = "Random Curve";

            graphView.AddSeries(series);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}