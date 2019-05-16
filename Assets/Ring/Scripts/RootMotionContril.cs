﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMotionContril : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorMove()
    {
        SendMessageUpwards("OnUpdateRM",(object)anim.deltaPosition);
    }
}