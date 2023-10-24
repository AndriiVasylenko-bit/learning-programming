using System.Diagnostics.CodeAnalysis;

void Resize<T>(ref T[] arrey, int newSize)
{
    if (newSize < 0)
        throw new ArgumentOutOfRangeException();

    T[] larrey = arrey;
    if (larrey == null)
        arrey = new T[newSize];

    if (larrey.Length != newSize)
    {
        T[] newArray = new T[newSize];
        for (int i = 0; i < arrey.Length && i < newArray.Length; i++)
            newArray[i] = arrey[i];
        arrey = newArray;
    }
}

void Insert<T>(ref T[] arrey, T value, int index)
{
    T[] varrey = new T[arrey.Length + 1];
    varrey[index] = value;

    for (int i = 0; i < index; i++)
        varrey[i] = arrey[i];

    for (int i = index; i < arrey.Length; i++)
        varrey[i + 1] = arrey[i];

    arrey = varrey;
}

void AddFirst<T>(ref T[] arrey, T value)
{
    Insert(ref arrey, value, 0);
}

void AddLast<T>(ref T[] arrey, T value)
{
    Insert(ref arrey, value, arrey.Length);
}

void Remuve<T>(ref T[] arrey, int index)
{
    T[] rarrey = new T[arrey.Length - 1];

    for (int i = 0; i < index; i++)
        rarrey[i] = arrey[i];

    for (int i = index + 1; i < rarrey.Length; i++)
        rarrey[i - 1] = arrey[i];

    arrey = rarrey;
}


void RemuveFirst<T>(ref T[] arrey)
{
    Remuve(ref arrey, 0);
}

void RemuveLast<T>(ref T[] arrey)
{
    Remuve(ref arrey, arrey.Length - 1);
}

int[] arr = { 1, 4, 6 };
string[] sarr = { "new", "hellow", "world" };
Resize(ref arr, 10);
Insert(ref arr, 3, 2);
AddFirst(ref arr, 4);
AddLast(ref arr, 3);
Remuve(ref arr, 0);
RemuveFirst(ref arr);
RemuveLast(ref arr);