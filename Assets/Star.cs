using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField]
    GameObject star;
    int objectCount = 0;
   

    private void Start()
    {
        
        objectCount = GameObject.FindGameObjectsWithTag("Star").Length;
        if (objectCount <= 200)
            StartCoroutine(StarMaker());
    }

    void Update()
    {
     
        objectCount = GameObject.FindGameObjectsWithTag("Star").Length;
        Debug.Log(objectCount);
        if (objectCount >= 200)
            StopCoroutine(StarMaker());
    }


    IEnumerator StarMaker()
    {
        if (objectCount <= 200)
        {
            for (int j = 0; j < 5; j++)
            {
                transform.position += new Vector3(1, 0, 0);
                yield return new WaitForSeconds(0.1f);
            }
            Instantiate(star, transform.position, Quaternion.identity);
        }
    }
}