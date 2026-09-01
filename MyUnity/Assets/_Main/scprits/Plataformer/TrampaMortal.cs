using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerStats1.RestarVida();
        }
    }
    




}
    
