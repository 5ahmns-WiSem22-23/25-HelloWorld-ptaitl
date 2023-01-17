using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    char[,] array = new char[4, 3];

    string alphabet = "abcdefghijklmnopqrstuvwxyz";

    void Start()
    {
        int iterator = 0;

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                array[row, col] = alphabet[iterator];
                iterator++;
            }
        }

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Debug.Log(array[row, col]);
            }
        }

        Debug.Log($"Row: {array.GetLength(0)}");
        Debug.Log($"Column: {array.GetLength(1)}");
    }
}
