using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;

    private void OnCollisiononEnter2D(Collision2D collision2D)
    {
      if (collision2D.gameObject.tag == "Player")
        {
            Debug.Log("El jugaor ha recibido vida");
            _playerStats.RestaurarVida(10);

            Destroy(gameObject);
        }


    }

}
