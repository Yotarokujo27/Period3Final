using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody targetRb;
    private GameManager gameManager;
   
    public int pointValue;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
           
            gameManager.UpdateScore(pointValue);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (!gameObject.CompareTag("Bad") && gameManager.isGameActive)
        {
            
            gameManager.UpdateLives(-1);
        }
       
       
    }
    
}
