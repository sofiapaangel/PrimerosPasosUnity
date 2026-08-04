using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //variables

public float altura=1.62f;
public int edad=17;
public string nombre="Sofia";
public bool puedevotar=true;

public GameObject gameObject;
public Rigidbody2D rigibody2D;
public Collider2D collider2D;
public SpriteRenderer spriteRenderer;
public Transform transform;

private void Start()
{
    Debug.Log("Hola: " + nombre +  " tu edad es: " + edad  + " tu altura es: " + altura);
    rigibody2D.simulated = false;
    spriteRenderer.color = Color.red;
    transform.position = new Vector3(10, 0, 0);
}
private void Update()
{

}

}