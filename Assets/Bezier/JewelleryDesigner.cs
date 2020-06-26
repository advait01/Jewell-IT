﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelleryDesigner : MonoBehaviour
{
	public BezierSpline spline;

	public int frequency;

	public bool lookForward;

	public Transform[] items;

	public void SpawnGems()
	{
		if (frequency <= 0 || items == null || items.Length == 0)
		{
			return;
		}
		float stepSize = frequency * items.Length;
		stepSize = 1f / (stepSize - 1);
		
		
		for (int p = 0, f = 0; f < frequency; f++)
		{
			for (int i = 0; i < items.Length; i++, p++)
			{
				Transform item = Instantiate(items[i]) as Transform;
				Vector3 position = spline.GetPoint(p * stepSize);
				item.transform.localPosition = position;
				if (lookForward)
				{
					item.transform.LookAt(position + spline.GetDirection(p * stepSize));
				}
				item.transform.parent = transform;
			}
		}
	}
}
