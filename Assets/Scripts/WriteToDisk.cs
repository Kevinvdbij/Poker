using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteToDisk : MonoBehaviour
{
    public static string[] output = new string[1000];

    public static void WriteRoundToDisk()
    {
        System.IO.File.WriteAllLines(@"C:\Users\Game Developer\AppData\Local\PokerOpdracht\output.txt", output);
    }
}
