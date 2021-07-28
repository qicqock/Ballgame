using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruction : MonoBehaviour
{
    public ObjectIsDestroyed = false
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePosition(new Vector3(0f, 0f, -0.5f) * 3.5f * Time.deltaTime);

        Destroy(gameObject, 5f);
    }

    // frame 기준 이동
    // private void MoveTranslate(Vector3 moveVector)
    // {
    //     transform.Translate(moveVector);
    // }

    // position 기준 이동
    private void MovePosition(Vector3 newPos)
    {
        transform.position = transform.position + newPos;
    }

    private void RepeatObstruction(System.Double FreeTime)
    {
        Destroy(gameObject, FreeTime)
        Instantiate(gameObject, transform.position, Quaternion.Identity);
    }
}
