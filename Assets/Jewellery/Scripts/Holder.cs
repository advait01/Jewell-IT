﻿using UnityEngine;

public class Holder : MonoBehaviour
{
    private ScrollSnap _scrollSnap;

    private void Awake()
    {
        _scrollSnap = FindObjectOfType<ScrollSnap>();
    }

    public void DisplayNecklace()
    {
        transform.SetParent(_scrollSnap.selectedJewelleryBox);
        foreach (Transform child in transform)
        {
            child.gameObject.layer = 8;
        }

        transform.localPosition = new Vector3(0f, 1f, 2f);
        transform.localRotation = Quaternion.Euler(-20f, 0f, 0f);
        transform.localScale = new Vector3(4.5f, 4.5f, 4.5f);
    }
}
