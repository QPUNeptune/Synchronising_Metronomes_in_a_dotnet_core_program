using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Drawing;
using Timer = System.Threading.Timer;

namespace Synchronising_Metronomes_in_a_dotnet_core_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread plotThread = new Thread(Plot_thinghy) {IsBackground = true};
            plotThread.Start();
        }

        private void Plot_thinghy()
        {
            formsPlot1.plt.Colorset(Colorset.OneHalfDark);
            formsPlot1.Configure(enableRightClickMenu: false, lockVerticalAxis: true, enableScrollWheelZoom: false, enablePanning: false, enableZooming: false, enableDoubleClickBenchmark: false, showCoordinatesTooltip: false);
            formsPlot1.plt.Style(figBg: Color.FromArgb(32, 32, 32));
            formsPlot1.plt.Style(dataBg: Color.FromArgb(64, 64, 64));
            formsPlot1.plt.Ticks(color: Color.Gray);
            formsPlot1.plt.XLabel(color: Color.Gray, xLabel: "x");
            formsPlot1.plt.YLabel(color: Color.Gray, yLabel:"sin(x)");
            formsPlot1.plt.Legend(fontColor: Color.White);
            formsPlot1.plt.AxisBounds(minX: 0, minY: -1.10, maxY: 1.10);
            
        }

        private void Ying_yang_ploty_thang(double a, double b, double c, double k)
        {
            formsPlot1.plt.Clear();

            double[][] dataSet = new double[3][];

            if (kura_model.Checked)
                dataSet = Kuramoto_Model(a, b, c, k);
            if (parker_model.Checked)
                dataSet = Parker_Kuramoto_Model(a, b, c, k);

            formsPlot1.plt.PlotSignal(dataSet[0], lineWidth: 3, label: "A");
            formsPlot1.plt.PlotSignal(dataSet[1], lineWidth: 3, label: "B");
            formsPlot1.plt.PlotSignal(dataSet[2], lineWidth: 3, label: "B");

            formsPlot1.Render(skipIfCurrentlyRendering: true);

            }

        private double[][] Parker_Kuramoto_Model(double a, double b, double c, double k)
        {
            int count = 1300;
            double ab = a, bb = b, cb = c;
            double[] aa = new double[count], ba = new double[count], ca = new double[count];

            for (int i = 0; i < count; i++)
            {
                double ii = i * 0.03;
                aa[i] = Math.Sin(ii + ab);
                ba[i] = Math.Sin(ii + bb);
                ca[i] = Math.Sin(ii + cb);
                a = ab + k * (Math.Sin(ab - bb) + Math.Sin(ab - cb));
                b = bb + k * (Math.Sin(bb - ab) + Math.Sin(bb - cb));
                c = cb + k * (Math.Sin(cb - ab) + Math.Sin(cb - bb));
                ab = a;
                bb = b;
                cb = c;
            }

            return new[] {aa, ba, ca};
        }

        private double[][] Kuramoto_Model(double a, double b, double c, double k)
        {
            int count = 1300;
            double ab = a, bb = b, cb = c;
            double[] aa = new double[count], ba = new double[count], ca = new double[count];

            for (int i = 0; i < count; i++)
            {
                double ii = i * 0.03;
                aa[i] = Math.Sin(ii + ab);
                ba[i] = Math.Sin(ii + bb);
                ca[i] = Math.Sin(ii + cb);
                a = ab + k * (Math.Sin(bb - ab) + Math.Sin(cb - ab));
                b = bb + k * (Math.Sin(ab - bb) + Math.Sin(cb - bb));
                c = cb + k * (Math.Sin(ab - cb) + Math.Sin(bb - cb));
                ab = a;
                bb = b;
                cb = c;
            }
            return new []{aa, ba, ca};
        }

        private void waveA_Scroll(object sender, EventArgs e)
        {
            waveANum.Value = (decimal) (waveA.Value * 0.0001);
        }

        private void waveANum_ValueChanged(object sender, EventArgs e)
        {
            waveA.Value = (int) (waveANum.Value * 10000);
        }

        private void waveB_Scroll(object sender, EventArgs e)
        {
            waveBNum.Value = (decimal) (waveB.Value * 0.0001);
        }

        private void waveBNum_ValueChanged(object sender, EventArgs e)
        {
            waveB.Value = (int) (waveBNum.Value * 10000);
        }

        private void waveC_Scroll(object sender, EventArgs e)
        {
            waveCNum.Value = (decimal) (waveC.Value * 0.0001);
        }

        private void waveCNum_ValueChanged(object sender, EventArgs e)
        {
            waveC.Value = (int) (waveCNum.Value * 10000);
        }

        private void kSlide_Scroll(object sender, EventArgs e)
        {
            kNum.Value = (decimal) (kSlide.Value * 0.00001);
        }

        private void kNum_ValueChanged(object sender, EventArgs e)
        {
            kSlide.Value = (int) (kNum.Value * 100000);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread plotThread = new Thread(() => Ying_yang_ploty_thang((double) waveANum.Value, (double) waveBNum.Value, (double) waveCNum.Value, (double) kNum.Value)) {IsBackground = true};
            plotThread.Start();
        }

        private void kura_model_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = kura_model.Text;
        }

        private void parker_model_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = parker_model.Text;
        }
    }
}
