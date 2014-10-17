﻿using UnityEngine;
using System.Collections;

public class GridSpawnerShell : MonoBehaviour
{
	public GameObject shellObject;
	public GameObject interiorObject;

	public int numObjectsX = 1;
	public int numObjectsY = 1;
	public int numObjectsZ = 1;

	public Vector3 objectSpacing = Vector3.one;

	// Use this for initialization
	void Start ()
	{
		for(int x = 0; x < numObjectsX; x++)
		{
			for(int y = 0; y < numObjectsY; y++)
			{
				for(int z = 0; z < numObjectsZ; z++)
				{
					if(x == 0 || y == 0 || z == 0 || x == numObjectsX-1 || y == numObjectsY-1 || z == numObjectsZ-1)
					{
						Instantiate(shellObject,transform.position+transform.right*x*objectSpacing.x+transform.up*y*objectSpacing.y+transform.forward*z*objectSpacing.z,Quaternion.identity);
					}
					else
					{
						Instantiate(interiorObject,transform.position+transform.right*x*objectSpacing.x+transform.up*y*objectSpacing.y+transform.forward*z*objectSpacing.z,Quaternion.identity);
					}
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
