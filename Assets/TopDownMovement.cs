using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopDownMovement : MonoBehaviour
{
    int directionX;
    int directionY;
    [SerializeField]
    float speed;
    [SerializeField]
    float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directionX = 0;
        directionY = 0;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            directionX--;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            directionX++;
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            directionY--;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        { 
            directionY++;
        }
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x + directionX * speed * Time.deltaTime, pos.y + directionY * speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="enemy")
        {
            health--;
            if(health <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}