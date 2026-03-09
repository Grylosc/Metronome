using System.Diagnostics;
using System.Media;
using System.Security.Policy;

namespace Metronome
{
    public partial class MainForm : Form
    {
        private uint count = 4; // 拍数
        private uint onpu = 4;  // 基準音符
        private uint bpm = 100; // テンポ

        private bool isMetronomeRunning = false;
        private SoundPlayer one = new SoundPlayer("one.wav");
        private SoundPlayer two = new SoundPlayer("two.wav");
        private int cooltime = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                uint countkari = uint.Parse(CountBox.Text);
                count = countkari;
            }
            catch
            {
                CountBox.Text = count.ToString();
            }
            try
            {
                uint onpukari = uint.Parse(OnpuBox.Text);
                if (onpukari != 0)
                {
                    onpu = onpukari;
                }
                else
                {
                    OnpuBox.Text = onpu.ToString();
                }
            }
            catch
            {
                OnpuBox.Text = onpu.ToString();
            }
            try
            {
                uint bpmkari = uint.Parse(TempoBox.Text);
                if (bpmkari != 0)
                {
                    bpm = bpmkari;
                }
                else
                {
                    TempoBox.Text = bpm.ToString();
                }
            }
            catch
            {
                TempoBox.Text = bpm.ToString();
            }
            isMetronomeRunning = true;
            cooltime = (int)((60.000 / (int)bpm / ((int)onpu / 4.000)) * 1000.000);
            Debug.WriteLine($"cooltime: {cooltime}");
            Task.Run(RunMetronome);
            
        }
        private void StopButton_Click(Object sender, EventArgs e)
        {
            isMetronomeRunning = false;
        }
        private async void RunMetronome()
        {
            int i = (int)count;
            while (isMetronomeRunning)
            {
                if (count != 0)
                {
                    if (i == (int)count)
                    {
                        i = 1;
                        one.Play();
                        Task.Delay(cooltime).Wait();
                    } else
                    {
                        two.Play();
                        Task.Delay(cooltime).Wait();
                        i++;
                    }
                }
                else
                {
                    two.Play();
                    Task.Delay(cooltime).Wait();
                }
            }
        }
    }
}
