using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
      // logic = GameObject.FindGameObjectsWithTag("Logic").GetComponent<LogicScript>();
       logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(5);
        }
       
    }
}
