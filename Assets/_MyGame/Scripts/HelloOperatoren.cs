using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    void Start()
    {
        #region Arrithmetische Operatoren
        Debug.Log($"Arrithmetische Operatoren machen z.B. aus 0 + 1 = {(0 + 1).ToString()}");
        #endregion

        #region Gleichheitsoperatoren
        Debug.Log($"Gleichheitsoperatoren sagen z.B. aus, das 0 == 1 {(0 == 1).ToString()} ist");
        #endregion

        #region Vergelichoperatoren
        Debug.Log($"Vergelichoperatoren sagen z.B. aus, das 0 < 1 {(0 < 1).ToString()} ist");
        #endregion

        #region Logische Operatoren
        Debug.Log($"Logische Operatoren sagen z.B. aus, das true && false {(true && false).ToString()} sind");
        #endregion

        #region Zuweisungsoperatoren
        int sampleInt = 1;
        Debug.Log($"Zuweisungsoperatoren sorgen z.B. dafür, dass sampleInt von 1 zu {(sampleInt += 1).ToString()} wird");
        #endregion
    }
}
