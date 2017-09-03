﻿using System;
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
            input.Normalize();
            normilizedInput = input;                   
        }       

        public void train()
        {
            // Hold back some data for a final validation.
            model.HoldBackValidation(0.3, true, 1001);
            // Choose whatever is the default training type for this model.
            model.SelectTrainingType(normilizedInput);
            // Use a 5-fold cross-validated train.  Return the best method found.            
            trainingMethod = (IMLRegression)model.Crossvalidate(5, true);

            // Display the training and validation errors.
            Console.WriteLine(@"Training error: " + model.CalculateError(trainingMethod, model.TrainingDataset));
            Console.WriteLine(@"Validation error: " + model.CalculateError(trainingMethod, model.ValidationDataset));
            Console.WriteLine(@"Final model: " + trainingMethod);
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
            var source = new CSVDataSource(inputLocation, false, CSVFormat.DecimalPoint);
            var csv = new ReadCSV(inputLocation, false, CSVFormat.DecimalPoint);
            csv.Next();
            VersatileMLDataSet data = new VersatileMLDataSet(source);
            var outputColumnDefinition = data.DefineSourceColumn("y", 0, ColumnType.Nominal);
            
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
            FileInfo networkFile = new FileInfo(location);
            Encog.Persist.EncogDirectoryPersistence.SaveObject(networkFile, model);
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
