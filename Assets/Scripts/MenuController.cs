using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public static void AnarEscenaPlay()
    {
        SceneManager.LoadScene("EscenaJoc");
    }

    public static void AnarEscenaMenu()
    {}

    public static void AnarEscenaResultat()
    {}

    public static void SortirAplicacio()
    {
        Application.Quit(); // Aquest metode només funciona en una  build. No per debug.

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Per a que funcioni en debug.
        #endif
    }

}
