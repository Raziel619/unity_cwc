using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vheicle forward
        transform.Translate(new Vector3(0, 0, 0.01f));
    }
}
