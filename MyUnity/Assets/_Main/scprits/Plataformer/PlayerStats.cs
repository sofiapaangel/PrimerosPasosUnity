using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RestarVida()
    {
        _puntosVida = _puntosVida - 10;
    }
}
