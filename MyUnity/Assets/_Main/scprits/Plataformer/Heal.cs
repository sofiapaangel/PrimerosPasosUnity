using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("El jugador suma vida");
            _playerStats.SumarVida(10);

            Destroy(gameObject);
        }



    }
}
