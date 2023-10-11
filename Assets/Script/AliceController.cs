using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliceController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        
        Vector2 position = transform.position;
        //每秒移动5个单位
        position.x+= horizontal*5.0f*Time.deltaTime;
        position.y+= vertical*5.0f*Time.deltaTime;
        transform.position = position;
    }
}
