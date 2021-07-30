using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruction : MonoBehaviour
{
    public GameObject roofWall;
    public GameObject floorWall;
    public GameObject leftWall;
    public GameObject rightWall;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Routine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Routine()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);
            float heightPosition = Random.Range(-2f, 1.5f);
            float widthPosition = Random.Range(-4f, 0f);
            // Instantiate(roofWall, new Vector3(0,3.35f,5), Quaternion.identity);
            // Instantiate(floorWall, new Vector3(0,1.1f,5), Quaternion.identity);
            Instantiate(roofWall, new Vector3(0,heightPosition + 4f,5), Quaternion.identity);
            Instantiate(floorWall, new Vector3(0,heightPosition,5), Quaternion.identity);
            Instantiate(leftWall, new Vector3(widthPosition,2.3f,5), Quaternion.identity);
            Instantiate(rightWall, new Vector3(widthPosition + 4f,2.3f,5), Quaternion.identity);
        }
    }
}
