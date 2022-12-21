using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    void Start()
    {
        int x = true ? 1 : 2;

        #region Variante "if"
        if (x == 0)
        {
            Debug.Log("x ist 0");
            return;
        }

        if(x == 1)
        {
            Debug.Log("x ist 1");
            return;
        }

        if (x == 2)
        {
            Debug.Log("x ist 2");
            return;
        }
        #endregion

        #region Variante "else if"
        if (x == 0)
        {
            Debug.Log("x ist 0");
        }

        else if (x == 1)
        {
            Debug.Log("x ist 1");
        }

        else if (x == 2)
        {
            Debug.Log("x ist 2");
        }
        #endregion

        #region Variante "switch"
        switch(x) {
            case 0:
                Debug.Log("x ist 0");
                break;
            case 1:
                Debug.Log("x ist 1");
                break;
            case 2:
                Debug.Log("x ist 2");
                break;
            default:
                Debug.Log("x ist weder 0, noch 1 oder 2");
                break;
        }
        #endregion
    }
}
