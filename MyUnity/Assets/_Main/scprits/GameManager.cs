using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }

public void SalirDelJuego()
    {
        Application.Quit();
    }
    
public void PausarElJuego()
    {
        Time.timeScale = 0;
    }

    public void RenundarElJuego()
    {
        Time.timeScale = 1;
    }

}
