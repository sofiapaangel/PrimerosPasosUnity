using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    public void SumarFillAmount(float amount = 0.1f)
    {
        _barra.fillAmount += amount;
    }
    public void RestarFillAmount(float amount =0.1f)
    {
        _barra.fillAmount -= amount;
    }
    public void ColorBarra(Color myColor)
    {
        _barra.color = myColor;
    }
}