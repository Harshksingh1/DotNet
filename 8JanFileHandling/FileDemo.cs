using System;
class FileDemo
{
    public void Writetext()
    {
        FileStream fileStream=new FileStream(@"C:\Users\harsh\Desktop\oops\Data\test.txt",FileMode.Append,FileAccess.Write);
        StreamWriter streamWriter=new StreamWriter(fileStream);
        Console.WriteLine("Enter some text: ");
        string str=Console.ReadLine();
        streamWriter.WriteLine(str);
        streamWriter.Close();
        fileStream.Close();
    }
    public void ReadText()
    {
        FileStream fileStream=new FileStream(@"C:\Users\harsh\Desktop\oops\Data\test.txt",FileMode.Open,FileAccess.Read);
        StreamReader streamreader=new StreamReader(fileStream);
        streamreader.BaseStream.Seek(0,SeekOrigin.Begin);
        string str=streamreader.ReadLine();
        while (str != null)
        {
            Console.WriteLine(str);
            str=streamreader.ReadLine();
        }
        Console.ReadLine();
        streamreader.Close();
        fileStream.Close();
    }
}