using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //variables

[SerializeField] private int _edad=17;
private float _velocidad= 15.5f;
private string nombre="Sofia";
private bool isJumping=false;
public float fuerza= 1000f;

[SerializeField] private Rigidbody2D _rigibody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
       _rigibody2D.AddForce(Vector2.right * fuerza);
       
        Debug.Log("Mi edad es: "+_edad);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Edad: "+_edad);
    }
}
