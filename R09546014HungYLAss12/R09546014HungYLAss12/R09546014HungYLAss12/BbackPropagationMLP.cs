using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R09546014HungYLAss12
{
    class BbackPropagationMLP
    {
        float[][] x; // neuron values
        float[][][] w; // weights
        Point[][] pts;//for UI to show NN
        float[][] e; // epsilon; partial derivative of error with respect to net value.
        int[] n; // numbers of neuron on layers
        int inputDimension; // dimension of input vector
        int inputNumber; // number of instances on the data set
        int numberOfTrainningVectors; // number of instances that are serving as training data
        float[,] originalInputs; // original instances of input vectors (without normalization)
        float[,] inputs; // normalized input vectors
        float[] inputMax; // upper bounds on all components of input vectors
        float[] inputMin; // lower bounds on all components of input vectors
        int inputWidth; // dimension in width for a two-dimensional input vector
        int targetDimension; // dimension of target vector
        float[,] originalTargets; // original instances of target vectors (without normalization)
        float[,] targets; // normalized target vectors
        float[] targetMax; // upper bounds on all components of target vectors
        float[] targetMin; // lower bounds on all components of target vectors
        int[] vectorIndices; // array of shuffled indices of data instances; the front portion is training vectors;
        //the rear portion is testing vectors

        float rootMeanSquareError = 0.0f; // root mean square of error for an epoch of data training
        float rootMeanSuqareErrorBest = float.MaxValue;
        int layerNumber; // number of neuron layer (including the input layer)
        Random randomizer = new Random();
        float learningRate = 0.999f; // learning rate, specified by the user
        Series rMSE = new Series("Epoch RMS of Errors");//for UI to show the decrese of root mean square error




        /// <summary>
        /// The factor of reducing the eta epoch by epoch. That is
        /// eta <-- LearningRate * eta
        /// </summary>
        [Category("Training Setting")]

        public float LearningRate
        {
            get { return learningRate; }
            set { learningRate = value; }
        }
        float eta; // step size that specify the update amount on each weight
        float initialEta = 0.7f; // initial step size, specified by the user
        /// <summary>
        /// Initialize variable of the eta (can be regarded as step size).
        /// </summary>
        [Category("Training Setting")]

        public float InitialEta
        {
            set { initialEta = value; }
            get { return initialEta; }
        }
        /// <summary>
        /// Current root mean square after an epoch training.
        /// </summary>
        [Browsable(false)]
        public float RootMeanSquareError
        {
            get { return rootMeanSquareError; } //set { rootMeanSquare = value; }
        }
        [Category("Training Setting")]

        public int EpochLimit
        {
            get; set;
        } = 200;

        [Browsable(false)]

        public int TrainingTimes
        {
            get; set;
        }

        [Browsable(false)]

        public Series RMSE { get => rMSE; }


        [Browsable(false)]

        public int TargetDimension { get => targetDimension; }






        /// <summary>
        /// Read in the data set from the given file stream. Configure the portions of training
        /// and testing data subsets. Original data are stored, bounds on each component of
        /// input vector and target vector are founds, and normalized data set is prepared.
        /// </summary>
        /// <param name="sr">file stream</param>
        /// <param name="trainingRatio">portion of trainning data</param>
        public void ReadInDataSet(StreamReader sr, float trainingRatio)
        {
            char[] separators = new char[] { ',', ' ' };
            string s = sr.ReadLine();
            string[] items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            inputNumber = Convert.ToInt32(items[0]);
            inputDimension = Convert.ToInt32(items[1]);
            targetDimension = Convert.ToInt32(items[2]);
            inputWidth = Convert.ToInt32(items[3]);

            originalInputs = new float[inputNumber, inputDimension];
            originalTargets = new float[inputNumber, targetDimension];
            inputs = new float[inputNumber, inputDimension];
            targets = new float[inputNumber, targetDimension];

            inputMax = new float[inputDimension];
            inputMin = new float[inputDimension];
            targetMax = new float[targetDimension];
            targetMin = new float[targetDimension];

            numberOfTrainningVectors = (int)Math.Floor(trainingRatio * inputNumber);

            for (int i = 0; i < inputDimension; i++)
            {
                inputMax[i] = float.MinValue;
                inputMin[i] = float.MaxValue;
            }

            for (int i = 0; i < targetDimension; i++)
            {
                targetMax[i] = float.MinValue;
                targetMin[i] = float.MaxValue;
            }



            for (int r = 0; r < inputNumber; r++)
            {
                s = sr.ReadLine();

                for (int c = 0; c < inputDimension; c++)
                {
                    originalInputs[r, c] = s[c];

                    if (inputMax[c] < originalInputs[r, c]) inputMax[c] = originalInputs[r, c];
                    if (inputMin[c] > originalInputs[r, c]) inputMin[c] = originalInputs[r, c];


                }

                for (int c = inputDimension; c < inputDimension + targetDimension; c++)
                {
                    originalTargets[r, c - inputDimension] = s[c];


                    if (targetMax[c - inputDimension] < originalTargets[r, c - inputDimension]) targetMax[c - inputDimension] = originalTargets[r, c - inputDimension];
                    if (targetMin[c - inputDimension] > originalTargets[r, c - inputDimension]) targetMin[c - inputDimension] = originalTargets[r, c - inputDimension];
                }
            }


            //Normalize the data set
            for (int r = 0; r < inputNumber; r++)
            {
                for (int c = 0; c < inputDimension; c++)

                {   //avoid divide by 0
                    if ((inputMax[c] - inputMin[c]) != 0) inputs[r, c] = (originalInputs[r, c] - inputMin[c]) / (inputMax[c] - inputMin[c]);
                    else { inputs[r, c] = 0; }

                }

                for (int c = 0; c < targetDimension; c++)
                {
                    //avoid divide by 0
                    if ((targetMax[c] - targetMin[c]) != 0) targets[r, c] = (originalTargets[r, c] - targetMin[c]) / (targetMax[c] - targetMin[c]);
                    else { targets[r, c] = 0; }
                }

            }

        }

        /// <summary>
        /// Configure the topology of the NN with the user specified numbers of hidden
        /// neuorns and layers.
        /// </summary>
        /// <param name="hiddenNeuronNumbers">list of numbers of neurons of hidden layers</param>
        public void ConfigureNeuralNetwork(int[] hiddenNeuronNumbers)
        {
            layerNumber = hiddenNeuronNumbers.Length + 2;
            n = new int[layerNumber];
            n[0] = inputDimension + 1;//+1 is for bias
            n[layerNumber - 1] = targetDimension + 1;//+1 is for bias


            for (int i = 1; i < layerNumber - 1; i++)
            {
                n[i] = hiddenNeuronNumbers[i - 1] + 1;
            }

            //for ploting NN graph
            pts = new Point[layerNumber][];
            for (int l = 0; l < pts.Length; l++)
            {
                pts[l] = new Point[n[l]];
            }



            //可能這邊出問題? Initializaition of n[] 
        }

        /// <summary>
        /// Randomly shuffle the orders of the data in the data set.
        /// </summary>
        private void RandomizeIndices()
        {
            vectorIndices = new int[inputNumber];
            int pos = -1;
            int temp = -1;

            for (int i = 0; i < inputNumber; i++) vectorIndices[i] = i;
            for (int c = inputNumber - 1; c > 1; c--)
            {
                pos = randomizer.Next(c + 1);
                temp = vectorIndices[c];
                vectorIndices[c] = vectorIndices[pos];
                vectorIndices[pos] = temp;
            }

            //宣告暫存array for swap
            float[] tempInput = new float[inputDimension];
            float[] tempTarget = new float[targetDimension];

            for (int i = 0; i < inputNumber; i++)
            {
                if (vectorIndices[i] != i)
                {
                    //deal with inputs

                    //把第i個vector移至tempInput暫存
                    for (int j = 0; j < inputDimension; j++) tempInput[j] = inputs[i, j];
                    //Array.Copy(inputs, i * inputDimension, tempInput,0,inputDimension);

                    //把第v[i]個vector移至第i個vector
                    for (int j = 0; j < inputDimension; j++) inputs[i, j] = inputs[vectorIndices[i], j];
                    //Array.Copy(inputs, vectorIndices[i] * inputDimension, inputs, i * inputDimension, inputDimension);

                    //把暫存的vector移到第v[i]個vector
                    for (int j = 0; j < inputDimension; j++) inputs[vectorIndices[i], j] = tempInput[j];
                    //Array.Copy(tempInput,0, inputs, vectorIndices[i] * inputDimension, inputDimension);

                    //deal with targets

                    //把第i個vector移至tempTarget暫存
                    for (int j = 0; j < targetDimension; j++) tempTarget[j] = targets[i, j];
                    //Array.Copy(targets, i * targetDimension, tempTarget, 0, targetDimension);

                    //把第v[i]個vector移至第i個vector
                    for (int j = 0; j < targetDimension; j++) targets[i, j] = targets[vectorIndices[i], j];
                    //Array.Copy(targets, vectorIndices[i] * targetDimension, targets, i * targetDimension, targetDimension);

                    //把暫存的vector移到第v[i]個vector
                    for (int j = 0; j < targetDimension; j++) targets[vectorIndices[i], j] = tempTarget[j];


                }

            }



        }
        /// <summary>
        /// Randomly set values of weights between [-1,1] and randomly shuffle the orders of all
        /// the datum in the data set. Reset value of initial eta and root mean square to 0.0.
        /// </summary>
        public void ResetWeightsAndInitialCondition()
        {
            w = new float[layerNumber][][];
            x = new float[layerNumber][];
            e = new float[layerNumber][];
            for (int l = 1; l < layerNumber; l++)
            {
                //weights in each layer
                w[l] = new float[n[l]][];
                //for (int neurons = 1; neurons <= n[l]; neurons++)

                for (int neurons = 1; neurons < n[l]; neurons++)
                {
                    w[l][neurons] = new float[n[l - 1]];
                    for (int weights = 0; weights < n[l - 1]; weights++)
                    {

                        w[l][neurons][weights] = (float)(randomizer.NextDouble() * 2.0 - 1.0);
                    }
                }
            }

            //new neurons  in each layer
            for (int l = 0; l < layerNumber; l++)
            {
                x[l] = new float[n[l]];//待確認
            }

            //new error in each layer
            for (int l = 1; l < layerNumber; l++)
            {
                e[l] = new float[n[l]];//待確認
            }

            ////inputs as neuron value for input layer 
            //for (int neurons = 0; neurons < n[0] ; neurons++)
            //{
            //    x[0][neurons] = 


            RandomizeIndices();

            InitialEta = 0.0f;
            rootMeanSquareError = 0.0f;
            rootMeanSuqareErrorBest = float.MaxValue;


        }



        //…

        /// <summary>
        /// Sequentially loop through each training datum of the training data whose indices are
        /// randomly shuffled in vectorIndices[] array, to perform on-line training of the NN.
        /// </summary>
        public void TrainAnEpoch()
        {
            TrainingTimes += 1;
            float v = 0.0f;
            float errorSquareSum = 0.0f;
            rootMeanSquareError = 0.0f;
            float sumation = 0.0f;
            int layerNumberMinusOne = layerNumber - 1;



            for (int j = 0; j < numberOfTrainningVectors; j++)
            {
                ///feed an training vector to input layer

                x[0][0] = 1;//bias

                for (int t = 0; t < inputDimension; t++) x[0][t + 1] = inputs[j, t];

                /// forward computing for all neuron values.

                for (int l = 1; l < layerNumber; l++)
                {
                    for (int k = 1; k < n[l]; k++)
                    {
                        sumation = 0;
                        v = 0;

                        for (int i = 0; i < n[l - 1]; i++)
                        {
                            v = w[l][k][i] * x[l - 1][i];

                            sumation += v;
                        }
                        //using Sigmoid as activation function

                        x[l][k] = 1 / (1 + (float)Math.Exp(-sumation));

                    }
                }


                //這邊待修改QQ

                /// compute the epsilon values for neurons on the output layer

                //deal with Error L,k(output layer)
                errorSquareSum = 0;
                for (int k = 1; k < n[layerNumberMinusOne]; k++)
                {
                    e[layerNumberMinusOne][k] = -2 * (targets[j, k - 1] - x[layerNumberMinusOne][k]) * x[layerNumberMinusOne][k] * (1 - x[layerNumberMinusOne][k]);
                    errorSquareSum += (targets[j, k - 1] - x[layerNumberMinusOne][k]) * (targets[j, k - 1] - x[layerNumberMinusOne][k]);
                }
                rootMeanSquareError += errorSquareSum;




                /// backward computing for the epsilon values
                //deal with Error l,k(hidden layer)
                sumation = 0;
                for (int l = 1; l < layerNumberMinusOne; l++)
                {
                    for (int k = 1; k < n[l]; k++)
                    {
                        sumation = 0;
                        for (int i = 1; i < n[l + 1]; i++) sumation += e[l + 1][i] * w[l + 1][i][k];//

                        e[l][k] = x[l][k] * (1 - x[l][k]) * sumation;
                    }
                }

            }



            //Evaluated at the end of an epoch

            rootMeanSquareError /= (numberOfTrainningVectors * n[layerNumber - 1]);

            rootMeanSquareError = (float)Math.Sqrt(rootMeanSquareError);

            rMSE.Points.AddXY(TrainingTimes, rootMeanSquareError);







            if (rootMeanSquareError < rootMeanSuqareErrorBest)
            {
                rootMeanSuqareErrorBest = rootMeanSquareError;
                /// update weights for all weights by using epsilon and neuron values for each training vector
                for (int l = 1; l < layerNumber; l++)
                {
                    for (int k = 1; k < n[l]; k++)
                    {
                        for (int i = 0; i < n[l-1]; i++)
                        {
                            w[l][k][i] = w[l][k][i] - learningRate * e[l][k] * x[l - 1][i];
                        }
                    }
                }
            }




            /// update step size of the updating amount after an epoch
            learningRate *= 0.9f;



            //float[] tmpinput = new float[inputDimension];
            //float[] compareResult = new float[targetDimension];
            //int predictIdx = -1;
            //float predictProb;
            //int groundtrouthIdx = -1;
            //float groundtruthProb;
            //for (int j = 0; j < numberOfTrainningVectors; j++)
            //{
            //    predictProb = 0;
            //    groundtruthProb = 0;
            //    for (int t = 0; t < inputDimension; t++)
            //    {
            //        tmpinput[t] = inputs[j, t];

            //    }
            //    compareResult = ComputeResults(tmpinput);



            //}

            //for (int j = numberOfTrainningVectors; j < inputNumber; j++)
            //{
            //    predictProb = 0;
            //    groundtruthProb = 0;

            //    //對答案
            //    for (int t = 0; t < targetDimension; t++)
            //    {

            //        if (predictProb < compareResult[t])
            //        {
            //            predictProb = compareResult[t];
            //            predictIdx = t;
            //        }

            //        if (groundtruthProb < targets[j, t])
            //        {
            //            groundtruthProb = targets[j, t];
            //            groundtrouthIdx = t;
            //        }

            //    }

            //    confusionMatrix[predictIdx, groundtrouthIdx] += 1;


            //}


        }


        /// <summary>
        /// Compute the output vector for an input vector. Both vectors are in the raw
        /// format. The input vector is subject to scaling first before forward computing.
        /// Output vector is then scaled back to raw format for recognition.
        /// </summary>
        /// <param name="input">input vector in raw format</param>
        /// <returns>output vector in raw format</returns>
        public float[] ComputeResults(float[] input)
        {

            float[] results = null;
            float v;
            results = new float[targetDimension];
            float sumation = 0;




            ///feed an testining vector to input layer

            x[0][0] = 1;//bias

            for (int t = 0; t < inputDimension; t++) x[0][t + 1] = input[t];

            /// forward computing for all neuron values.

            for (int l = 1; l < layerNumber; l++)
            {
                for (int k = 1; k < n[l]; k++)
                {
                    sumation = 0;
                    v = 0;

                    for (int i = 0; i < n[l - 1]; i++)
                    {
                        v = w[l][k][i] * x[l - 1][i];

                        sumation += v;
                    }
                    //using Sigmoid as activation function

                    x[l][k] = 1 / (1 + (float)Math.Exp(-sumation));

                }
            }


            float maxProbability = 0;
            int CurrentMaxIndex = 0;

            for (int k = 1; k < n[layerNumber - 1]; k++)
            {
                if (maxProbability < x[layerNumber - 1][k])
                {
                    maxProbability = x[layerNumber - 1][k];
                    //results[CurrentMaxIndex] = k;
                    CurrentMaxIndex = k;


                    //    CurrentMaxIndex = k - 1;
                    //}
                    //else
                    //{
                    //    results[k - 1] = 0;

                    //}

                }
            }
            for(int j = 0; j < results.Length;j++)
            {
                if (j == CurrentMaxIndex-1) results[j] = 1;
                else { results[j] = 0; }
            }

            return results;

        }
        /// <summary>
        /// If the data set is a classification data set, test the data to generate confusing table.
        /// The index of the largest component of the target vector is the targeted class id.
        /// The index of the largest component of the computed output vector is the resulting class id.
        /// If both the targeted class id and the resulting class id are the same, then the test
        /// data is correctly classified.
        /// </summary>
        /// <param name="confusingTable">generated confusing table</param>
        /// <returns>the ratio between the number of correctly classified testing data and the total number of testing
        ///data.</returns>
        public float TestingClassification(out int[,] confusingTable)
        {
            confusingTable = new int[targetDimension, targetDimension];

            int successedCount = 0;


            float[] tmpinput = new float[inputDimension];
            float[] compareResult = new float[targetDimension];
            int predictIdx = -1;
            float predictProb;
            int groundtrouthIdx = -1;
            float groundtruthProb;
            for (int j = numberOfTrainningVectors; j < inputNumber; j++)
            {
                predictProb = 0;
                groundtruthProb = 0;
                for (int t = 0; t < inputDimension; t++)
                {
                    tmpinput[t] = inputs[j, t];

                }
                compareResult = ComputeResults(tmpinput);





                //對答案
                for (int t = 0; t < targetDimension; t++)
                {

                    if (predictProb < compareResult[t])
                    {
                        predictProb = compareResult[t];
                        predictIdx = t;
                    }

                    if (groundtruthProb < targets[j, t])
                    {
                        groundtruthProb = targets[j, t];
                        groundtrouthIdx = t;
                    }

                }

                confusingTable[predictIdx, groundtrouthIdx] += 1;


            }

            for (int j = 0; j < targetDimension; j++)
            {
                successedCount += confusingTable[j, j];
            }


            //            float v;
            ////...
            return (float)successedCount / (float)(inputNumber - numberOfTrainningVectors);
        }



        public void DrawMLP(Graphics g, Rectangle bound)
        {
            if (n == null) return;
            int dw = bound.Width / pts.Length;
            int woff = dw / 2;
            Rectangle rect = Rectangle.Empty;
            int halfUnit = bound.Height / 30;
            rect.Width = rect.Height = halfUnit + halfUnit; //這邊寫死，但是寬跟高隨視窗放大縮小仍會放大縮小
            Font myfont = new Font("Arial", 10.0f);

            for (int l = 0; l < layerNumber; l++)
            {
                int dh = bound.Height / n[l];
                int hoff = dh / 2;
                for (int c = 0; c < n[l]; c++)
                {
                    pts[l][c].X = woff + l * dw;
                    pts[l][c].Y = hoff + c * dh;
                    rect.X = pts[l][c].X - halfUnit;
                    rect.Y = pts[l][c].Y - halfUnit;
                    g.DrawString(Convert.ToString(x[l][c]), myfont, Brushes.Gray, rect.X,rect.Y);

                    g.DrawRectangle(Pens.Red, rect);
                }
            }
            Point start = new Point();
            for (int l = 0; l < layerNumber; l++)
            {


                for (int c = 0; c < n[l]; c++)
                {
                    start = pts[l][c];

                    if (l < layerNumber - 1)
                    {
                        for (int neuronIdxNextlayer = 0; neuronIdxNextlayer < n[l + 1]; neuronIdxNextlayer++)
                        {
                            g.DrawLine(Pens.Silver, start, pts[l + 1][neuronIdxNextlayer]);

                            //    g.DrawString(Convert.ToString(w[l + 1][neuronIdxNextlayer + 1][c]),
                            //     myfont, Brushes.Gray, (start.X + pts[l + 1][neuronIdxNextlayer].X) / 2, (start.Y + pts[l + 1][neuronIdxNextlayer].Y) / 2);
                        }
                    }
                    }
                }
            }
        }



    }




