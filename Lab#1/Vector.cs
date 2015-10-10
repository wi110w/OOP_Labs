using System;

namespace Lab_1
{
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

        public static Vector operator +(Vector X, Vector Y)
        {
            X.CheckLengthEqual(Y);
            float[] total = new float[X.DimensionCount];
            for (int i = 0; i < X.DimensionCount; i++)
            {
                total[i] = X.coordinates[i] + Y.coordinates[i];
            }

            return new Vector(total);
        }

        public static Vector operator -(Vector X, Vector Y)
        {
            X.CheckLengthEqual(Y);
            float[] total = new float[X.DimensionCount];
            for (int i = 0; i < X.DimensionCount; i++)
            {
                total[i] = X.coordinates[i] - Y.coordinates[i];
            }

            return new Vector(total);
        }

        public static Vector operator *(Vector vector, float num)
        {
           float[] total = new float[vector.DimensionCount];
            for (int i = 0; i < vector.DimensionCount; i++)
            {
                total[i] = vector.coordinates[i] * num;
            }

            return new Vector(total);
 
        }

        public static float operator *(Vector X, Vector Y)
        {
            X.CheckLengthEqual(Y);
            float total = 0;
            for (int i = 0; i < X.DimensionCount; i++)
            {
                total += X.coordinates[i] * Y.coordinates[i];
            }

            return total;

        }

        public float EucledianNorm
        {
            get
            {
                float total = 0;
                for (int i = 0; i < coordinates.Length; i++)
                {
                    total += coordinates[i] * coordinates[i];
                }
                return (float)Math.Sqrt(total);
            }
        }

        public float MaxNorm
        {
            get
            {
                float total = Math.Abs(coordinates[0]);
                for (int i = 0; i < coordinates.Length; i++)
                {
                    total = Math.Max(total, Math.Abs(coordinates[i]));
                }

                return total;
            }
        }

        public float ManhattanNorm
        {
            get
            {
                float total = 0;
                for (int i = 0; i < coordinates.Length; i++)
                {
                    total += Math.Abs(coordinates[i]);
                }
                return total;
            }
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
