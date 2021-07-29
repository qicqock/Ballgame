using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruction : MonoBehaviour
{
    public GameObject roofWall;
    public GameObject floorWall;

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
            float wallPosition = Random.Range(-1f, 2.7f);
            // Instantiate(roofWall, new Vector3(0,3.35f,5), Quaternion.identity);
            // Instantiate(floorWall, new Vector3(0,1.1f,5), Quaternion.identity);
            Instantiate(roofWall, new Vector3(0,wallPosition + 4f,5), Quaternion.identity);
            Instantiate(floorWall, new Vector3(0,wallPosition,5), Quaternion.identity);
        }
    }
}
