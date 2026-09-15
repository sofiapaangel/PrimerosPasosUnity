using TMPro.EditorUtilities;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManger;

    private void OnCollisiononEnter2D(Collision2D collision2D)
    {
      if (collision2D.gameObject.tag == ("Player"))
        {
            
            _playerStats.RestaurarVida(10);
            _uiManger.SumarFillAmount(0.1f);

            Destroy(this.gameObject);
        }


    }

}
