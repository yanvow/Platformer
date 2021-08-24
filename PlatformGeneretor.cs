using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneretor : MonoBehaviour {

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float deltaMaxHeight;
    private float deltaHeight;



    //public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    public ObjectPooler[] theObjectPools;

    // Use this for initialization
    void Start () {
        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;

        platformWidths = new float[theObjectPools.Length];

        for(int i = 0; i < theObjectPools.Length; i++)
        {
             platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;


    } 


	
	// Update is called once per frame
	void Update () {
	
        if(transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin,distanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);

            deltaHeight = transform.position.y + Random.Range(deltaMaxHeight, -deltaMaxHeight);

            if (deltaHeight > maxHeight)
            {
                deltaHeight = maxHeight;
            }
            else if (deltaHeight < minHeight)
            {
                deltaHeight = minHeight;
            }

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]) / 2 + distanceBetween, deltaHeight, transform.position.z);
  
            //Instantiate(/*thePlatform*/ thePlatforms[platformSelector], transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]) / 2, transform.position.y, transform.position.z);


        }



    }
}
