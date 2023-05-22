using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser._02logic.Settings
{
    internal class Mode
    {
        public string Name { get; private set; }
        public double InputLayers { get; private set; }
        public double HiddenLayers { get; private set; }
        public double NeuronsCount { get; private set; }
        public double OutputValues { get; private set; }
        public double LearningRate { get; private set; }
        public double TrainCount { get; private set; }
        public Boolean Editable { get; private set; }
        public Mode(string name, double inputLayers, double hiddenLayers, double neuronsCount, double outputValues, double learningRate, double trainCount, bool editable)
        {
            Name = name;
            InputLayers = inputLayers;
            HiddenLayers = hiddenLayers;
            NeuronsCount = neuronsCount;
            OutputValues = outputValues;
            LearningRate = learningRate;
            TrainCount = trainCount;
            Editable = editable;
        }

        public Boolean CompareTo(Mode m) {
            return (m.Name == Name && m.InputLayers == InputLayers && m.HiddenLayers == HiddenLayers
                && m.OutputValues == OutputValues && m.LearningRate == LearningRate
                 && m.NeuronsCount == NeuronsCount && m.TrainCount == TrainCount && m.Editable == Editable);
        }
    }
}
