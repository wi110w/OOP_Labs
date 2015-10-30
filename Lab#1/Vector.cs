namespace Lab_1
{
    using System;
    
    public class Vector
    {
        private float[] coordinates;
        public Vector(params float[] coord)
        {
            coordinates = coord;
        }
        public Vector(int N)
        {
            coordinates = new float[N];
        }
        public float this[int x]
        {
            get
            {
               return coordinates[x];
            }
            set
            {
                coordinates[x] = value;
            }
        }

        public int DimensionCount
        {
            get { return coordinates.Length; }
        }

        private void CheckLengthEqual(Vector other)
        {
            if (this.DimensionCount != other.DimensionCount)
                throw new ArgumentException("Different length of vectors.");
        }

        public float GetEucledianNorm()
        {
            float total = 0;
            for (int i = 0; i < coordinates.Length; i++)
            {
                total += coordinates[i] * coordinates[i];
            }
            return (float)Math.Sqrt(total);
        }

        public float GetMaxNorm()
        {
            float total = Math.Abs(coordinates[0]);
            for (int i = 0; i < coordinates.Length; i++)
            {
                total = Math.Max(total, Math.Abs(coordinates[i]));
            }

            return total;
        }

        public float GetManhattanNorm()
        {
            float total = 0;
            for (int i = 0; i < coordinates.Length; i++)
            {
                total += Math.Abs(coordinates[i]);
            }
            return total;
        }

        public Vector Add(Vector Y)
        {
            CheckLengthEqual(Y);
            float[] total = new float[this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                total[i] = this.coordinates[i] + Y.coordinates[i];
            }

            return new Vector(total);
        }

        public Vector Subtract(Vector Y)
        {
            CheckLengthEqual(Y);
            float[] total = new float[this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                total[i] = this.coordinates[i] - Y.coordinates[i];
            }

            return new Vector(total);
        }

        public float Multiply(Vector Y)
        {
            CheckLengthEqual(Y);
            float total = 0;
            for (int i = 0; i < this.DimensionCount; i++)
            {
                total += this.coordinates[i] * Y.coordinates[i];
            }

            return total;
        }

        public Vector Multiply(float num)
        {
            float[] total = new float[this.DimensionCount];
            for (int i = 0; i < this.DimensionCount; i++)
            {
                total[i] = this.coordinates[i] * num;
            }

            return new Vector(total);
        }

        public static Vector operator +(Vector X, Vector Y)
        {
            return X.Add(Y);
        }

        public static Vector operator -(Vector X, Vector Y)
        {
            return X.Subtract(Y);
        }

        public static Vector operator *(Vector vector, float num)
        {
            return vector.Multiply(num);
        }

        public static float operator *(Vector X, Vector Y)
        {
            return X.Multiply(Y);
        }

        public override bool Equals(object obj)
        {
            Vector other = obj as Vector;
            if (other == null)
                return false;
            for (int i = 0; i < this.DimensionCount; i++)
            {
                if (coordinates[i] != other.coordinates[i])
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            string strVector = "";
            strVector += "(";
            for (int i = 0; i < this.DimensionCount; i++)
            {
                if (i == this.DimensionCount - 1)
                    strVector += coordinates[i].ToString() + ")";
                else strVector += coordinates[i].ToString() + ",";
            }

            return strVector;
        }
    }
}
