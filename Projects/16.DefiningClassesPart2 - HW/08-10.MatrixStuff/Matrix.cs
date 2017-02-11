using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;//needed for NumberFormatInfo


//the constraints used for the class are from:
//http://stackoverflow.com/questions/3329576/generic-constraint-to-match-numeric-types
//second upvoted answer by Mark H

namespace _08_10.MatrixStuff
{

    //struct constraint should probably be excluded -- need more research/testing for validation -- TO DO!
    class Matrix<T>
        where T : struct, 
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
    {

        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            matrix = new T[rows, cols];
        }

        public int Length
        {
            get { return matrix.Length; }
        }

        public int GetLength(int x)
        {
            return matrix.GetLength(x);
        }
        public T this[int rows, int cols]
        {
            get { return matrix[rows, cols]; }
            set { matrix[rows, cols] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            //this is just a precaution, although the class constraints should not allow for such types to be passed as paramters
            var type = typeof(T);
            if (type == typeof(String) ||
                type == typeof(DateTime)) throw new ArgumentException(String.Format("The type {0} is not supported", type.FullName), "T");

            if (matrix1.Length != matrix2.Length)
                throw new ArgumentException("The matrices are of different size. Operation cannot be performed.");

            Matrix<T> resultMatrix = new Matrix<T>(matrix1.GetLength(0), matrix1.GetLength(1));
            double newMember = 0;

            for(int rows = 0; rows < matrix1.GetLength(0); rows ++)
            {
                for (int cols = 0; cols < matrix1.GetLength(1); cols++)
                {
                    try
                    {
                        newMember = (matrix1[rows, cols].ToDouble(NumberFormatInfo.CurrentInfo) + 
                                     matrix2[rows, cols].ToDouble(NumberFormatInfo.CurrentInfo));

                        resultMatrix[rows, cols] = (T)Convert.ChangeType(newMember, type);
                        //check this link for more info:
                        //http://stackoverflow.com/questions/8171412/cannot-implicitly-convert-type-int-to-t
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("The operation failed.", ex);
                    }
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            var type = typeof(T);
            if (type == typeof(String) ||
                type == typeof(DateTime)) throw new ArgumentException(String.Format("The type {0} is not supported", type.FullName), "T");

            if (matrix1.Length != matrix2.Length)
                throw new ArgumentException("The matrices are of different size. Operation cannot be performed.");

            Matrix<T> resultMatrix = new Matrix<T>(matrix1.GetLength(0), matrix1.GetLength(1));
            double newMember = 0;

            for (int rows = 0; rows < matrix1.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix1.GetLength(1); cols++)
                {
                    try
                    {
                        newMember = (matrix1[rows, cols].ToDouble(NumberFormatInfo.CurrentInfo) -
                                    matrix2[rows, cols].ToDouble(NumberFormatInfo.CurrentInfo));

                        resultMatrix[rows, cols] = (T)Convert.ChangeType(newMember, type);
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("The operation failed.", ex);
                    }
                }
            }

            return resultMatrix;
        }


        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            var type = typeof(T);
            if (type == typeof(String) ||
                type == typeof(DateTime)) throw new ArgumentException(String.Format("The type {0} is not supported", type.FullName), "T");

            if (matrix1.Length != matrix2.Length)
                throw new ArgumentException("The matrices are of different size. Operation cannot be performed.");

            Matrix<T> resultMatrix = new Matrix<T>(matrix1.GetLength(0), matrix1.GetLength(1));
            double newMember = 0;

            for (int rows = 0; rows < matrix1.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix1.GetLength(1); cols++)
                {
                    newMember = 0;

                    for (int k = 0; k < matrix1.GetLength(0); k++)
                    {
                        newMember += (matrix1[rows, k].ToDouble(NumberFormatInfo.CurrentInfo) *
                                      matrix2[k, cols].ToDouble(NumberFormatInfo.CurrentInfo));
                    }
                        try
                        {
                            resultMatrix[rows, cols] = (T)Convert.ChangeType(newMember, type);
                        }
                        catch (Exception ex)
                        {
                            throw new ApplicationException("The operation failed.", ex);
                        }
                }
            }

            return resultMatrix;
        }


        //not done do not keep in mind -- TO DO finish this method
        public static bool operator true(Matrix<T> matrix)
        {
            bool hasNonZeroElements = true;
            double member = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    member = matrix[rows, cols].ToDouble(NumberFormatInfo.CurrentInfo);

                    if (member == 0)
                        hasNonZeroElements = false;
                }
            }

            return hasNonZeroElements;
        }
//end of class, end of namespace 
    }

}












