using System;
using System.IO;
namespace Lab_1
{
    class FileReader
    {
        public StreamReader OpenFile(string filename)
        {
            return new StreamReader(filename);
        }
        public Vector ReadVector(StreamReader reader)
        {
            string sizeStr = reader.ReadLine();
            int size = int.Parse(sizeStr);
            string coord = reader.ReadLine();
            string[] coords = coord.Split();

            Vector X = new Vector(size);
            for (int i = 0; i < coords.Length; i++)
            {
                float comp = float.Parse(coords[i]);
                X[i] = comp;
            }
            return X;
        }

        public Matrix ReadMatrix(StreamReader matrixReader)
        {
            string sizeStr = matrixReader.ReadLine();
            int size = int.Parse(sizeStr);
            float[,] m1 = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                string coord = matrixReader.ReadLine();
                string[] coords = coord.Split();
                for (int j = 0; j < size; j++)
                {
                    m1[i, j] = float.Parse(coords[j]);
                }
            }
            Matrix M = new Matrix(m1);
            return M;
        }

    }
}
