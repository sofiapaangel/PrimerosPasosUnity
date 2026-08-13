using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("El jugador ha muerto");
            Destroy(collision.gameObject);
        }
    }
    




}
    
