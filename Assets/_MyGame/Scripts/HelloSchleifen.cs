using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    [SerializeField]
    readonly int[][] sampleArray = { new int[] { 1, 2 }, new int[] { 1, 2, 3, 4 } };

    void Start()
    {
        for (int a = 0; a < sampleArray.Length; a++)
        {
            for (int b = 0; b < sampleArray[a].Length; b++)
            {
                int value = sampleArray[a][b];
                Debug.Log($"a: {a}, b: {b}: {value}");
            }
        }
    }
}
