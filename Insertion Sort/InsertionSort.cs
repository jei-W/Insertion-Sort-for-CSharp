using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class InsertionSort
    {
        public static void AscendingSort(int[] arg)
        {
            for( int i = 1; i < arg.Length; i++ )
            {
                int tmp = arg[i];

                for( int j = i - 1; j >= 0; j-- )
                {
                    if( tmp < arg[j] )
                    {
                        arg[j + 1] = arg[j];

                        if( j == 0 )
                        {
                            arg[j] = tmp;
                        }
                    }
                    else
                    {
                        arg[j + 1] = tmp;
                        break;
                    }
                }
            }
        }

        public static void DescendingSort( int[] arg )
        {
            for( int i = 1; i < arg.Length; i++ )
            {
                int tmp = arg[i];

                for( int j = i - 1; j >= 0; j-- )
                {
                    if( tmp > arg[j] )
                    {
                        arg[j + 1] = arg[j];

                        if( j == 0 )
                        {
                            arg[j] = tmp;
                        }
                    }
                    else
                    {
                        arg[j + 1] = tmp;
                        break;
                    }
                }
            }
        }
    }
}
