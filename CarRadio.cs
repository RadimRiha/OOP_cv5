using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    public class CarRadio
    {
        public double? TunedFrequency;
        public bool RadioOn;
        private Dictionary<int, double> presets = new Dictionary<int, double>();
        public CarRadio()
        {
            RadioOn = false;
            TunedFrequency = null;
        }
        public void SetPreset(int presetNumber, double presetFrequency)
        {
            if (presets.ContainsKey(presetNumber)) presets.Remove(presetNumber);
            presets.Add(presetNumber, presetFrequency);
        }
        public void TuneToPreset(int presetNumber)
        {
            if (!RadioOn) throw new Exception("Cannot tune a disaled radio!");
            if (!presets.ContainsKey(presetNumber)) throw new Exception("Cannot find preset!");
            TunedFrequency = presets[presetNumber];
        }
        public override string ToString()
        {
            return string.Format("Radio status: {0}\nTuned frequency: {1}MHz\n", RadioOn == true ? "On" : "Off", TunedFrequency);
        }
    }
}
