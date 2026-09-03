using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void SumarVida(int heal)

    {
        _puntosVida = _puntosVida + heal;
    }
}
