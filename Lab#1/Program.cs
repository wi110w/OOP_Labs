﻿namespace Lab_1
{
    using System;
    using System.IO;
    
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            FileReader reader = new FileReader();
            logger.Log("Application started", string.Empty, "Done");
            try
            {
                StreamReader vectorReader = null;
                StreamReader matrixReader = null;

                Vector X = reader.ReadVector(vectorReader, @"vectors.txt");
                logger.Log("Loaded X", string.Format("{0}", X), "Done");
                Vector Y = reader.ReadVector(vectorReader, @"vectors.txt");
                logger.Log("Loaded Y", string.Format("{0}", Y), "Done");
                Matrix A = reader.ReadMatrix(matrixReader, @"matrices.txt");
                logger.Log("Loaded A", string.Format("\n{0}", A), "Done");
                Matrix B = reader.ReadMatrix(matrixReader, @"matrices.txt");
                logger.Log("Loaded B", string.Format("\n{0}", B), "Done");
                Matrix C = reader.ReadMatrix(matrixReader, @"matrices.txt");
                logger.Log("Loaded C", string.Format("\n{0}", C), "Done");
                Matrix D = reader.ReadMatrix(matrixReader, @"matrices.txt");
                logger.Log("Loaded D", string.Format("\n{0}", D), "Done");
                //(A + C + 2D)^t * X + BY
                Matrix total = A + C;
                Matrix tempMatrix = A + C;
                logger.Log("Addition of A and C", string.Format("\n{0}   + \n{1}   = \n{2}", A, C, total), "Done");
                total += 2 * D;
                logger.Log("Addition of total and 2D", string.Format("\n{0}   + \n(2 * \n{1})   = \n{2}", tempMatrix, D, total), "Done");
                tempMatrix += 2 * D;
                total = total.Transposed();
                logger.Log("Transposing of total", string.Format("\n{0}   = \n{1}", tempMatrix, total), "Done");
                Vector result = total * X;
                Vector tempVector = total * X;
                logger.Log("Multiplication of total and X", string.Format("\n{0}   * \n{1} = {2}", total, X, result), "Done");
                result += B * Y;
                logger.Log("Addition of result and BY", string.Format("\n{0}\n   + \n(\n{1}   * \n{2}) = {3}", tempVector, B, Y, result), "Done");
                tempVector += B * Y;
                logger.Log("Euclid norm of result", string.Format("||{0}|| = {1}", tempVector, result.GetEucledianNorm()), "Done");
                logger.Log("Manhattan norm of result", string.Format("||{0}|| = {1}", tempVector, result.GetManhattanNorm()), "Done");
                logger.Log("Maximum norm of result", string.Format("||{0}|| = {1}", tempVector, result.GetMaxNorm()), "Done");

            }
            catch (Exception e)
            {
                logger.Log("Fail to make an action", e.Message, "FAIL");
            }
            try
            {
                StreamReader mFailReader = null;

                Matrix E = reader.ReadMatrix(mFailReader, @"mfails.txt");
                logger.Log("Loaded E", string.Format("\n{0}", E), "Done");
                Matrix F = reader.ReadMatrix(mFailReader, @"mfails.txt");
                logger.Log("Loaded F", string.Format("\n{0}", F), "Done");

                Matrix alert = E + F;
                logger.Log("Addition of E and F", string.Format("\n{0}   + \n{1}   = \n{2}", E, F, alert), "Done");
            }
            catch (Exception e)
            {
                logger.Log("Fail to make an action", e.Message, "FAIL");
            }
            try
            {
                StreamReader vFailReader = null;

                Vector W = reader.ReadVector(vFailReader, @"vfails.txt");
                logger.Log("Loaded W", string.Format("{0}", W), "Done");
                Vector Z = reader.ReadVector(vFailReader, @"vfails.txt");
                logger.Log("Loaded Z", string.Format("{0}", Z), "Done");

                Vector error = W + Z;
                logger.Log("Addition of W and Z", string.Format("{0} + {1} = {2}", W, Z, error), "Done");
            }
            catch (Exception e)
            {
                logger.Log("Fail to make an action", e.Message, "FAIL");
            }
        }
    }

}
