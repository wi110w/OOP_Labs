namespace Lab_1
{
    using System;
    using System.IO;
    
    class FileReader
    {
        private StreamReader OpenFile(string filename)   //encapsulate streamReader
        {
            return new StreamReader(filename);
        }

        public Vector ReadVector(StreamReader vectorReader, string filename)
        {
             vectorReader = this.OpenFile(filename);
            string sizeStr = vectorReader.ReadLine();
            int size = int.Parse(sizeStr);
            string coord = vectorReader.ReadLine();
            string[] coords = coord.Split();

            Vector X = new Vector(size);
            for (int i = 0; i < coords.Length; i++)
            {
                float comp = float.Parse(coords[i]);
                X[i] = comp;
            }

            return X;
        }

        public Matrix ReadMatrix(StreamReader matrixReader, string filename)
        {
            matrixReader = this.OpenFile(filename);
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
