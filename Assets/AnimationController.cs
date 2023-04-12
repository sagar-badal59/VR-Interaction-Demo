using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    
    int isWorkDone;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWorkDone = Animator.StringToHash("isWorkDone");
    }

    // Update is called once per frame
    void Update()
    {

        bool forwardPresseed = Input.GetKey("w");
        if (isWorkDone<1 && forwardPresseed)
        {
            animator.SetBool(isWorkDone, true);
        }
    }
}
