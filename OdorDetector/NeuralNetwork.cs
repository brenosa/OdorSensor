using System;
using Encog;
using Encog.ML;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Model;
using Encog.ML.Factory;
using Encog.ML.Data.Versatile;
using Encog.ML.Data.Versatile.Sources;
using Encog.ML.Data.Versatile.Columns;
using Encog.Util.CSV;
using System.IO;
using Encog.Util;
using Encog.Util.Simple;

namespace OdorDetector
{
    class NeuralNetwork
    {            
        EncogModel model;
        VersatileMLDataSet normilizedInput;
        IMLRegression trainingMethod;
        String inputLocation = @"input.csv";

        public void create()
        {
            VersatileMLDataSet input = getCSVData();           
            model  = new EncogModel(input);
            model.SelectMethod(input, MLMethodFactory.TypeFeedforward);
            model.Report = new ConsoleStatusReportable();
            input.Normalize();
            normilizedInput = input;                   
        }       

        public string train()
        {
            // Hold back some data for a final validation.
            model.HoldBackValidation(0.3, true, 1001);
            // Choose whatever is the default training type for this model.
            model.SelectTrainingType(normilizedInput);
            // Use a 5-fold cross-validated train.  Return the best method found.            
            trainingMethod = (IMLRegression)model.Crossvalidate(5, true);

            // Display the training and validation errors.
            return "Training error: " +
                model.CalculateError(trainingMethod, model.TrainingDataset) +
                "\r\nValidation error: " + model.CalculateError(trainingMethod, model.ValidationDataset) +
                "\r\nFinal model: " + trainingMethod;            
        }

        public string detect(string[] inputData)
        {
            //Normaliza dados
            NormalizationHelper helper = model.Dataset.NormHelper;
            IMLData normilizedInput = helper.AllocateInputVector();
            helper.NormalizeInputVector(inputData, ((BasicMLData)normilizedInput).Data, false);
                        
            Console.WriteLine(@"Neural Network Results:");
           
            IMLData output = trainingMethod.Compute(normilizedInput);
            /*Console.WriteLine("Input: ");
            for (int i = 0; i < inputData.Length; i++)
            {
                Console.WriteLine(inputData[i]);
            }*/
            Console.WriteLine("Output = " + output[0]);
            EncogFramework.Instance.Shutdown();

            return helper.DenormalizeOutputVectorToString(output)[0];                           
        }

        private VersatileMLDataSet getCSVData()
        {
            IVersatileDataSource source = new CSVDataSource(inputLocation, false, CSVFormat.DecimalPoint);
            var csv = new ReadCSV(inputLocation, false, CSVFormat.DecimalPoint);
            csv.Next();
            VersatileMLDataSet data = new VersatileMLDataSet(source);
            ColumnDefinition outputColumnDefinition = data.DefineSourceColumn("y", 0, ColumnType.Nominal);
            
            for (int i = 1; i < csv.ColumnCount; i++)
            {
                data.DefineSourceColumn("x", i, ColumnType.Continuous);
            }
            
            data.Analyze();
            data.DefineSingleOutputOthersInput(outputColumnDefinition);
            return data;
        }


        public void save(string location)
        {
            //FileInfo networkFile = new FileInfo(location);
            Encog.Persist.EncogDirectoryPersistence.SaveObject(File.Create(location), (EncogModel) model);
           //Encog.Persist.EncogDirectoryPersistence.SaveObject(networkFile, (EncogModel)model);
            //SerializeObject.Save(location, (EncogModel) model);
            //EncogUtility.SaveEGB(FileInfo location, data);
        }

        public void load(string filePath)
        {
            FileInfo networkFile = new FileInfo(filePath);
            model = (EncogModel)(Encog.Persist.EncogDirectoryPersistence.LoadObject(networkFile));
            //TODO normilize data??
            //TODO best method?
        }
    }
}
