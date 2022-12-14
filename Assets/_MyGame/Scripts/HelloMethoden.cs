using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    int startValue = 0;
    int startValue3 = 0;
    int startValue4 = 0;
    int startValue5 = 0;


    void Start()
    {
        Debug.Log("Hallo Methoden");

        Debug.Log("before startValue: " + startValue);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue);

        Debug.Log("before startValue3: " + startValue);
        IncrementBy(Random.Range(1, 10));
        Debug.Log("after startValue3: " + startValue);

        Debug.Log("before startValue4: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4: " + startValue4);

        Debug.Log("before startValue5: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after  startValue5: " + startValue5);
    }

    int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    void IncrementBy(int valToAdd)
    {
        startValue3 += Mathf.Abs(valToAdd);
    }

    void IncrementByOne()
    {
        startValue++;
    }

    // Sinnvoll wäre noch eine Methode zum Tracken von Variablen
    // das Loggen vor und nach einem Methodenaufruf würde dann in diese Methode ausgelagert werden

}