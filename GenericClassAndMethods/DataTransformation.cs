using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassAndMethods
{ 

    public static class DataTransformation
    {
        public static List<TOutput> ConvertTo<TInput, TOutput>(List<TInput> inputList, Func<TInput, TOutput> conversionFunction)
        {
            return inputList.Select(conversionFunction).ToList();
        }
    }


}
