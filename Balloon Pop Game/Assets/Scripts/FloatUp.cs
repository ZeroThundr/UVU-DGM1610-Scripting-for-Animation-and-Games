using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{
    public float moveSpeed;// speed at which the balloon moves

    public float upperBound;// threshold where the balloon gets destroyed

    private Balloon balloon;// reference the balloon gameobject

    private ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()

    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    
    void Update()
    {
        // Move the balloon upwards
        transform.Translate(Vector3.up * (moveSpeed * Time.deltaTime));
        
        //destroy balloon if it reaches the top boundary
        if (transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);//decreases score if balloon hits the threshold
            
            Destroy(gameObject);
        }
    }
}
