if (text[i] == a && text[i + 1] == a && text[i] != b)
{
    for (int j = text.Length - 1; j >= 0; j--)
    {
        empty = empty + text[i];
    }

    if (text == empty)
    {
        text = text.Replace("c", string.Empty);
        Console.WriteLine(text);
        Console.WriteLine("Zerkalni");
    }
}