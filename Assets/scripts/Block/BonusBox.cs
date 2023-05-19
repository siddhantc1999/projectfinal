using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBox : MonoBehaviour
{
    [SerializeField] GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HERE");
        Scoringsystem.Instance.Incrementgameplayscore();
       
        point.transform.parent = gameObject.transform;
     
        point.transform.position = transform.position;
        point.gameObject.active = true;
        point.GetComponent<Animator>().SetTrigger("pointsup");
       /* StartCoroutine(pointsactivefalse());*/
        //    Debug.Log("here in +1");
        //}
    }

    IEnumerator pointsactivefalse()
    {
        yield return new WaitForSeconds(2f);
        point.active = false;
    }
}
