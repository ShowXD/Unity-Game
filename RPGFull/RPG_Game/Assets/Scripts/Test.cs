using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CountDown");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime, Space.Self);
        }
    }
    /*
     * 
    IEnumerator CountDown()
    {
        int time = 60;
        while(time >= 0)
        {
            time -= 1;
            return null;
        }
        
    }
    */
}
