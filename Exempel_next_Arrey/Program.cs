int[] array = {11, 12, 13, 41, 15, 56, 17, 98};

int n = array.Length;
int find = 17;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
      Console.WriteLine(index);
        break;
    }
    index++;
}
