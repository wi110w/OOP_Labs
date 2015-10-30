namespace Lab_1
{
    using System;
    
    public class Matrix
    {
        private float[,] components;

        public Matrix(float[,] matrix)
        {
            this.components = matrix;
        }

        public int DimensionCount
        {
            get { return this.components.GetLength(0); }
        }

        public void CheckMatrixDimensionsEqual(Matrix other)
        {
            if(this.DimensionCount != other.DimensionCount || this.components.GetLength(1) != other.components.GetLength(1))
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

        public float GetEucledianNorm()
        {
            float total = 0;
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    total += this.components[i, j] * this.components[i, j];
                }
            }

            return (float)Math.Sqrt(total);
        }

        public float GetMaxSumRow()
        {
            float total = Math.Abs(this.components[0, 0]);
            for (int i = 0; i < this.DimensionCount; i++)
            {
                float temp = 0;
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    temp += Math.Abs(this.components[j, i]);
                }

                total = Math.Max(total, temp);
            }

            return total;
        }

        public float GetMaxSumCol()
        {
            float total = Math.Abs(this.components[0, 0]);
            for (int i = 0; i < this.DimensionCount; i++)
            {
                float temp = 0;

                for (int j = 0; j < this.DimensionCount; j++)
                {
                    temp += Math.Abs(this.components[i, j]);
                }

                total = Math.Max(total, temp);
            }

            return total;
        }

        public Matrix Add(Matrix B)
        {
            CheckMatrixDimensionsEqual(B);
            float[,] total = new float[this.DimensionCount, this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    total[i, j] = this.components[i, j] + B.components[i, j];
                }
            }

            return new Matrix(total);
        }

        public Matrix Subtract(Matrix B)
        {
            CheckMatrixDimensionsEqual(B);
            float[,] total = new float[this.DimensionCount, this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    total[i, j] = this.components[i, j] - B.components[i, j];
                }
            }

            return new Matrix(total);
        }

        public Matrix Multiply(Matrix B)
        {
            CheckMatrixDimensionsEqual(B);
            float[,] total = new float[this.DimensionCount, this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    for (int k = 0; k < this.components.GetLength(1); k++)
                        total[i, j] += this.components[i, k] * B.components[k, j];
                }
            }
            return new Matrix(total);
        }

        public Vector Multiply(Vector X)
        {
            CheckVectorMatrixDimensionsEqual(X);
            float[] total = new float[this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    total[i] += this.components[i, j] * X[j];
                }
            }
            return new Vector(total);
        }

        public Matrix Multiply(float num)
        {
            float[,] total = new float[this.DimensionCount, this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                for (int j = 0; j < this.DimensionCount; j++)
                {
                    total[i, j] = this.components[i, j] * num;
                }
            }
            return new Matrix(total);
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            return A.Add(B);
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            return A.Subtract(B);
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            return A.Multiply(B);
        }

        public static Vector operator *(Matrix A, Vector X)
        {
            return A.Multiply(X);
        }

        public static Matrix operator *(float num, Matrix A)
        {
            return A.Multiply(num);
        }

        public Matrix Transposed()
        {
            float[,] transposed = new float[this.DimensionCount, this.DimensionCount];
            for(int i = 0; i < this.DimensionCount; i++)
            {
                for(int j = 0; j < this.DimensionCount; j++)
                {
                    transposed[i, j] = this.components[j, i];
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
                    if (this.components[i, j] != other.components[i, j])
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
                        strMatrix += this.components[i, j].ToString() + ")";
                    else strMatrix += this.components[i, j].ToString() + " ";
                }
                strMatrix += "\n";
            }

            return strMatrix;
        }
    }
}
