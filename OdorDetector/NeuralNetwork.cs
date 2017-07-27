using System;
using Encog.ML.SVM;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Train;
using Encog.ML.SVM.Training;
using Encog;

namespace OdorDetector
{
    class NeuralNetwork
    {
        //private Encog.Neural.Networks.BasicNetwork network;
        private IMLDataSet trainingSet;
        private SupportVectorMachine network;

        //train set
        public static double[][] trainingData =
        {
            new[] {0.0, 0.0},
            new[] {0.0, 1.0},
            new[] {1.0, 0.0},
            new[] {1.0, 1.0}
        };
      
        //ideal output
        public static double[][] idealData =
        {            
            new[] {0.0}, //Gasolina
            new[] {1.0}, //Listerine
            new[] {2.0}, //Álcool de cozinha
            new[] {3.0} //Cerveja
        };

        //input test
        public static double[] inputData = { 0.9, 0.1 };
        

        public void create()
        {

            // create a neural network, without using a factory
            network = new SupportVectorMachine(2, false); // 2 input, & false for classification

            // create a neural network, without using a factory
            //network = new BasicNetwork();               
            //network.AddLayer(new BasicLayer(null, true, 2));
            //network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 3));
            //network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 3));
            //network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 1));
            //network.Structure.FinalizeStructure();
            //network.Reset();
        }

        public void train()
        {
            // create training data
            trainingSet = new BasicMLDataSet(trainingData, idealData);

            // train the neural network
            IMLTrain train = new SVMSearchTrain(network, trainingSet);

            int epoch = 1;

            do
            {
                train.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error:" + train.Error);
                epoch++;
            } while (train.Error > 0.01);

            train.FinishTraining();
        }

        public void test()
        {
            // test the neural network
            IMLData input = new BasicMLData(inputData);            
            //var testSet = new BasicMLDataSet(inputTest, XORIdeal);
            Console.WriteLine(@"Neural Network Results:");           
            IMLData output = network.Compute(input);

            Console.WriteLine("Input: ");
            for (int i = 0; i< inputData.Length; i++){
                Console.WriteLine(inputData[i]);
            }
            Console.WriteLine("Output = " + output[0]);
            Console.WriteLine("Ideal = 2");

            EncogFramework.Instance.Shutdown();
        }        
    }
}
