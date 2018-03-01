using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementsPlayer : MonoBehaviour
{
    [SerializeField]
    private string VerticalAxis;
    [SerializeField]
    private string HorizontalAxis;
    [SerializeField]
    private float Speed = 0.5f;
 
    //FixedUpdate se lance toutes les 0.02 secondes
    void FixedUpdate ()
	{  
        //Permet de get les inputs 
        float x = Input.GetAxisRaw(HorizontalAxis);
	    float y = Input.GetAxisRaw(VerticalAxis);

        //Crée le vecteur de déplacement
        Vector2 direction = new Vector2(x * Speed, y * Speed);

        //Applique le mouvement
        transform.Translate(direction);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            //Envoie un message dès qu'il détecte une collision avec qqch
            Debug.Log("I hit : " + other.tag);
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

}
