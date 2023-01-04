using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCont : MonoBehaviour
{
    private Animator myAnim;
    bool isRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isRunning = Input.GetKey(KeyCode.W);

        myAnim.SetBool("run", isRunning);
    }
}
