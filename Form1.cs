using System.Collections.Generic;
using System.Speech.Recognition;
using System.IO;
using CsvHelper;
using System.Windows.Forms;
using smite_voice2vgs.Entities;
using System.Globalization;
using System.ComponentModel.Design;
using System.Linq;

namespace smite_voice2vgs
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine speechRecognizer = new SpeechRecognitionEngine();
        bool firstload = true;
        char vgsKeybind;
        List<Command> commands = new List<Command>();
        IDictionary<string, string> vgs = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (firstload)
            {
                vgsKeybind = char.Parse("V");
                firstload = false;

            }
            btn_disable.Enabled = false;
            Choices choices = new Choices();
            choices.Add(createVGSLibrary());
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(choices);
            Grammar grammar = new Grammar(grammarBuilder);

            speechRecognizer.LoadGrammarAsync(grammar);
            speechRecognizer.SetInputToDefaultAudioDevice();

            speechRecognizer.SpeechRecognized += SpeechRecognizer_SpeechRecognized;
        }

        private void SpeechRecognizer_SpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
            string[] vgs = createVGSLibrary();
            if (vgs.Contains(e.Result.Text))
            {
                logBox.Text += "\n" + DateTime.Now + ": " + e.Result.Text + " - " + vgsKeybind + "A3";
                SendKeys.Send(vgsKeybind + "A1");
            }
        }

        private void btn_disable_Click(object sender, EventArgs e)
        {
            if (btn_disable.Enabled)
            {
                speechRecognizer.RecognizeAsyncStop();
                btn_disable.Enabled = false;
            }
            btn_enable.Enabled = true;
            txtbox_keybind.Enabled = true;
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
                btn_disable.Enabled = true;
            }
            btn_enable.Enabled = false;
            txtbox_keybind.Enabled = false;
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }

        private string[] createVGSLibrary()
        {
            ICollection<string> result = vgs.Keys;
            
            using (var csv = new CsvReader(new StreamReader(".\\commands.csv"), CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while(csv.Read())
                {
                    vgs.Add(csv.GetField("Test"), csv.GetField("PC"));
                }
            }

            return result.ToArray();
        }

        private void txtbox_keybind_TextChanged(object sender, EventArgs e)
        {
            vgsKeybind = char.Parse(txtbox_keybind.Text);
        }
    }
}