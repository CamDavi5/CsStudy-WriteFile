using System.IO;

try
{

    StreamWriter sw = new StreamWriter(/*Path of WriteInHere.txt*/);
    sw.WriteLine("Bum bum bum, ba bum ba bum -");
    sw.WriteLine("A duck walked up to a lemonade stand,");
    sw.WriteLine("And he said to the man, running the stand,");
    sw.WriteLine("'Hey'! (ba ba bum) 'Got any grapes?'");
    sw.WriteLine("- Excerpt of the The Duck Song");
    sw.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}
