namespace CSharpLearning._0x0002;

public class TwoArray
{
    /*
     * 1  2  3  4
     * 2  4  7  11
     * 3  5  8  12
     * 4  6  10 39   搜索行列递增矩阵最佳方法
     */
    public string FindNumFromArray(int[,] array,int target=0)
    {
        string result = "";
        //获取行数
        int i = 0;
        //获取列数
        int j = array.GetLength(1) - 1;
        var row = array.GetLength(0);
        string arrayString = "";
        while (i < row && j >= 0)
        {
            arrayString += PrintArray(array, i, j);
            arrayString += Environment.NewLine;
            //从二维数组的右上角开始遍历比较
            if (target < array[i, j])
            {
                j--;
            }
            else if (target > array[i, j])
            {
                i++;
            }
            else
            {
                arrayString += $"Find! [{i}, {j}]";
                break;
            }
        }

        result = arrayString;
        return result;
    }

    private string PrintArray(int[,] array,int row,int col)
    {
        string result = "";
        row = array.GetLength(0)-row;
        // col = array.GetLength(1)-col;
        for (int i = 0; i < row; i++)
        {
            result += "[";
            for (int j = 0; j < col; j++)
            {
                result+=$"{array[i, j]} ";
            }
            result += $"]{Environment.NewLine}";
        }
        return result;
    }
}