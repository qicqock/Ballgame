using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // FixedSize();
    }

    // Update is called once per frame
    void Update()
    {
        MovePosition(new Vector3(0f, 0f, -0.5f) * 3.8f * Time.deltaTime);
   
        Destroy(gameObject, 3.5f);
    }

    // position 기준 이동
    private void MovePosition(Vector3 newPos)
    {
        transform.position = transform.position + newPos;
    }
}
