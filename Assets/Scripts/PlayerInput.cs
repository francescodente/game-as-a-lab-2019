﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Plane groundPlane;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        groundPlane = new Plane(Vector3.up, Vector3.zero);
    }

    private void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, 0, z).normalized;

        playerMovement.SetDirection(direction);
    }

    private void HandleRotation()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (groundPlane.Raycast(mouseRay, out float distance))
        {
            Vector3 mousePointOnGround = mouseRay.GetPoint(distance);
            //Debug.DrawLine(mouseRay.origin, mousePointOnGround, Color.red);
            playerMovement.LookAt(mousePointOnGround);
        }
    }
}