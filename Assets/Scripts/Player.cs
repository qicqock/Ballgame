using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;
    // [SerializeField] private Transform groundCheckTransform = null;
    // private이면 이 클래스 안에서만 안다는 의미
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision) {
        GameObject.Find("Canvas").GetComponent<Menu>().Enter_Restart();
    }

    // Update is called once per frame
    void Update()
    // 한 프레임마다 실행하는 함수라고 보면 됨
    {
        // Check if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }
    // FixedUpdate is called once every physic update
    // 프레임마다 실행되는 것이 아닌 일정한 시간마다 호출됨
    // 입력과 관련된 것들은 일단 무조건 하나가 update()에 들어가야됨 
    // -> 입력을 잃어버리는 경우가 생길수 있기 때문에
    //  마우스 및 키보드 입력값은 Update에서 처리하고 캐릭터의 움직임 부분 같은 물리적인 계산은 FixedUpdate
    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(horizontalInput * 2.0f, rigidbodyComponent.velocity.y, 0);

        // if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        // {
        //     return;
        // }

        if (jumpKeyWasPressed)
        {
            // 점프 할때 얼마나 점프할지 결정. 현재는 6만큼 점프하도록 설정 \
            // rigidbodyComponent.velocity[1]는 현재 y축의 속도를 의미한다. 이 값을 빼주어 항상 일정한 만큼 점프하도록 설정함.
            rigidbodyComponent.AddForce(Vector3.up * (6 - rigidbodyComponent.velocity[1]), ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }

    public void ResetPlayerPosition(){
        rigidbodyComponent.transform.position = new Vector3(0,2.3f,0);
    }
}
