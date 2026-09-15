using UnityEngine;

public class GroundCheck : MonoBehaviour
{ public bool isGround;
    private void OnTriggerStay2D(Collider2D collision)
    {
       Debug.Log ("Toco el suelo");
       isGround = true;
    }
   
     private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Estoy saltando");
        isGround = false;
        
    }
    
}

