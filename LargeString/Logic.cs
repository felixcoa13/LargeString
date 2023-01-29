using LargeString.Abstractions;

namespace LargeString
{
    class Logic
    {
        public static void SetMaxResult(Result prevResult, Result result)
        {
            if (prevResult.Length > result.Length)
            {
                result.Length = prevResult.Length;
                result.Letter = prevResult.Letter;
            }
        }

        public static void SetResults(char currentLetter, Result prevResult, Result result, bool lastLetter)
        {
            if (prevResult.Letter == currentLetter)
            {
                prevResult.Length += 1;
                if (lastLetter)
                {
                    SetMaxResult(prevResult, result);
                }
            }
            else
            {
                SetMaxResult(prevResult, result);
                prevResult.Length = 1;
                prevResult.Letter = currentLetter;
            }
        }

        public static Result GetMaxRecurringLetter(char[][] array)
        {
            var prevHorizontalResult = new Result();
            var prevVerticalResult = new Result();
            var prevBottomDiagonalResult = new Result();
            var prevTopDiagonalResult = new Result();
            var result = new Result();
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    var isLastLetter = j == array.Length - 1;
                    var currentHorizontalLetter = array[i][j];
                    SetResults(currentHorizontalLetter, prevHorizontalResult, result, isLastLetter);

                    var currentVerticalLetter = array[j][i];
                    SetResults(currentVerticalLetter, prevVerticalResult, result, isLastLetter);

                    var isValidIndex =  j + i < array.Length;
                    if(isValidIndex)
                    {
                        var isLastDiagonalLetter =  j + i == array.Length - 1;
                        var currentBottomDiagonalLetter = array[i + j][j];
                        SetResults(currentBottomDiagonalLetter, prevBottomDiagonalResult, result, isLastDiagonalLetter);
                        
                        var currentTopDiagonalLetter = array[j][i + j];
                        SetResults(currentTopDiagonalLetter, prevTopDiagonalResult, result, isLastDiagonalLetter);
                    }
                    
                }
                prevHorizontalResult.Clear();
                prevVerticalResult.Clear();
                prevTopDiagonalResult.Clear();
                prevBottomDiagonalResult.Clear();
            }
            return result;
        }
    }
}
