using SpeechLib;
using System.Collections.Generic;
using System.Speech.Recognition;
using System.IO;
using CsvHelper;

namespace smite_voice2vgs
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine speechRecognizer = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] result =
                {"attack left lane", "attack middle lane", "attack right lane", "attack fire giant", "attack gold fury", "attack the titan", "attack left tower", "attack middle tower", "attack right tower",
                "enemies in left lane", "enemies in middle lane", "enemies in right lane", "enemy ultimate incoming", "enemies have returned to base", "enemy ultimate down", "enemies behind us", "enemies at the fire giant", "enemies at the gold fury", "enemies in the left jungle", "enemies in the right jungle", "enemies in the jungle", "enemies at our titan", "enemy spotted",
                "be careful left", "be careful middle", "be careful right", "return to base", "careful", "be careful in the jungle",
                "defend left lane", "defend middle lane", "defend right lane", "defend the fire giant", "defend the gold fury", "defend the titan",
                "enemy missign left", "enemy missign middle", "enemy missign right", "enemy missign",
                "gank left lane", "gank middle lane", "gank right lane",
                "help middle lane", "help left lane", "help right lane", "need healing", "help",
                "enemies incoming left", "enemies incoming middle", "enemies incoming right", "incoming left", "incoming middle", "incoming right",
                "ward left", "waard middle", "ward right", "ward fire giant", "ward gold fury", "need wards", "waard here",
                "retreat left lane", "retreat middle lane", "retreat right lane", "retreat from the jungle", "save your self",
                "hello"};


            Choices choices = new Choices();
            foreach(var s in result)
            {
                choices.Add(s);
            }
            
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
                logBox.Text += e.Result.Text;
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
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
                btn_disable.Enabled = true;
            }
            btn_enable.Enabled = false;
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private static string[] createVGSLibrary()
        {
            string[] result =
                {"attack left lane", "attack middle lane", "attack right lane", "attack fire giant", "attack gold fury", "attack the titan", "attack left tower", "attack middle tower", "attack right tower",
                "enemies in left lane", "enemies in middle lane", "enemies in right lane", "enemy ultimate incoming", "enemies have returned to base", "enemy ultimate down", "enemies behind us", "enemies at the fire giant", "enemies at the gold fury", "enemies in the left jungle", "enemies in the right jungle", "enemies in the jungle", "enemies at our titan", "enemy spotted",
                "be careful left", "be careful middle", "be careful right", "return to base", "careful", "be careful in the jungle",
                "defend left lane", "defend middle lane", "defend right lane", "defend the fire giant", "defend the gold fury", "defend the titan",
                "enemy missign left", "enemy missign middle", "enemy missign right", "enemy missign",
                "gank left lane", "gank middle lane", "gank right lane",
                "help middle lane", "help left lane", "help right lane", "need healing", "help",
                "enemies incoming left", "enemies incoming middle", "enemies incoming right", "incoming left", "incoming middle", "incoming right",
                "ward left", "waard middle", "ward right", "ward fire giant", "ward gold fury", "need wards", "waard here",
                "retreat left lane", "retreat middle lane", "retreat right lane", "retreat from the jungle", "save your self",
                ""};
            
            return result;
        }

        private void txtbox_keybind_TextChanged(object sender, EventArgs e)
        {
            txtbox_keybind.Text = "V";
        }
    }
}