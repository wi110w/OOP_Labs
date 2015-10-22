using System;

namespace Lab_1
{
    public class Matrix
    {
        private float[,] components;

        public Matrix(float[,] matrix)
        {
            components = matrix;
        }

        public int DimensionCount
        {
            get { return components.GetLength(0); }
        }

        public float EucledianNorm
        {
            get
            {
                float total = 0;
                for (int i = 0; i < this.DimensionCount; i++)
                {
                    for (int j = 0; j < this.DimensionCount; j++)
                    {
                        total += components[i, j] * components[i, j];
                    }
                }

                return (float)Math.Sqrt(total);
            }
        }

        public float MaxSumRow
        {
           get { 
                float total = Math.Abs(components[0,0]);
                for (int i = 0; i < this.DimensionCount; i++)
                {
                    float temp = 0;
                    for (int j = 0; j < this.DimensionCount; j++)
                    {
                        temp += Math.Abs(components[j, i]);
                    }
                    total = Math.Max(total, temp);
                }
                return total;
            }
        }

        public float MaxSumCol
        {
            get
            {
                float total = Math.Abs(components[0, 0]);
                for (int i = 0; i < this.DimensionCount; i++)
                {
                    float temp = 0;
                    for (int j = 0; j < this.DimensionCount; j++)
                    {
                        temp += Math.Abs(components[i, j]);
                    }
                    total = Math.Max(total, temp);
                }

                return total;
            }
        }

        public void CheckMatrixDimensionsEqual(Matrix other)
        {
            if(this.DimensionCount != other.DimensionCount || components.GetLength(1) != other.components.GetLength(1))
            {
                throw new ArgumentException("Different dimensions of matrix.");
            }
        }

        public void CheckVectorMatrixDimensionsEqual(Vector v)
        {
            if(this.DimensionCount != v.DimensionCount)
            {
                throw new ArgumentException("Different dimensions of vector or matrix.");
            }
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            A.CheckMatrixDimensionsEqual(B);
            float[,] total = new float[A.DimensionCount, A.DimensionCount];
            for (int i = 0; i < A.DimensionCount; i++)
            {
                for (int j = 0; j < A.DimensionCount; j++)
                {
                    total[i, j] = A.components[i, j] + B.components[i, j];
                }
            }

            return new Matrix(total);
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            A.CheckMatrixDimensionsEqual(B);
            float[,] total = new float[A.DimensionCount, A.DimensionCount];
            for (int i = 0; i < A.DimensionCount; i++)
            {
                for (int j = 0; j < A.DimensionCount; j++)
                {
                    total[i, j] = A.components[i, j] - B.components[i, j];
                }
            }

            return new Matrix(total);
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            A.CheckMatrixDimensionsEqual(B);
            float[,] total = new float[A.DimensionCount, A.DimensionCount];
            for (int i = 0; i < A.DimensionCount; i++)
            {
                for (int j = 0; j < A.DimensionCount; j++)
                {
                    for (int k = 0; k < A.components.GetLength(1); k++)
                        total[i, j] += A.components[i, k] * B.components[k, j];
                }
            }
            return new Matrix(total);
        }

        public static Vector operator *(Matrix A, Vector X)
        {
            A.CheckVectorMatrixDimensionsEqual(X);
            float[] total = new float[A.DimensionCount];
            for (int i = 0; i < A.DimensionCount; i++)
            {
                for (int j = 0; j < A.DimensionCount; j++)
                {
                     total[i] += A.components[i, j] * X[j];
                }
            }
            return new Vector(total);
        }

        public static Matrix operator *(float num, Matrix A)
        {
            float[,] total = new float[A.DimensionCount, A.DimensionCount];
            for (int i = 0; i < A.DimensionCount; i++)
            {
                for (int j = 0; j < A.DimensionCount; j++)
                {
                     total[i, j] = A.components[i, j] * num;
                }
            }
            return new Matrix(total);
        }

        public Matrix Transposed()
        {
            float[,] transposed = new float[this.DimensionCount, this.DimensionCount];
            for(int i = 0; i < this.DimensionCount; i++)
            {
                for(int j = 0; j < this.DimensionCount; j++)
                {
                    transposed[i, j] = components[j, i];
                }
            }

            return new Matrix(transposed);
        }

        public override bool Equals(object obj)
        {
            Matrix other = obj as Matrix;
            if (other == null)
            {
                return false;
            }
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    if (components[i, j] != other.components[i, j])
                        return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            string strMatrix = "";
            for (int i = 0; i < this.DimensionCount; i++)
            {
                strMatrix += "(";
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    if (j == this.DimensionCount - 1)
                        strMatrix += components[i, j].ToString() + ")";
                    else strMatrix += components[i, j].ToString() + " ";
                }
                strMatrix += "\n";
            }

            return strMatrix;
        }
    }
}
