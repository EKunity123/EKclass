using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemymovment : MonoBehaviour
{
    int directionX;
    int directionY;
    [SerializeField]
    float speed;
    [SerializeField]
    float health;
    [SerializeField]
    GameObject player; 
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 p_pos = player.transform.position;
        rb.velocity = (p_pos - pos).normalized * Time.deltaTime * speed;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health--;
            if (health <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}

