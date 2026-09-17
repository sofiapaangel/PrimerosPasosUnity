using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Update()
    {
        
    }

}
