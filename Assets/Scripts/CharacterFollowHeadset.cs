using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterFollowHeadset : MonoBehaviour
{
    private CharacterController character;
    private float gravity = -9.81f;
    private float fallingSpeed;
    //[HideInInspector]
    public LayerMask groundLayer; // For ease of use, comment out the [HideInInspector] command -> save the script -> go back to Unity -> Let it load for the update ->
                                  // Then choose "Everything" from the dropdown menu of this variable in the inspector!
    private float additionalHeight = 0.2f;
    //[HideInInspector]
    public Transform headRig;

    private void Start()
    {
        character = GetComponent<CharacterController>();
        character.radius = 0.2f;
        character.height = 1.8f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CapsuleFollowHeadSet();
        bool isGrounded = CheckIfGrounded();

        if (isGrounded)
            fallingSpeed = 0;
        else
            fallingSpeed += gravity * Time.fixedDeltaTime;

        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);
    }

    private void CapsuleFollowHeadSet()
    {
        character.height = headRig.position.y + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(headRig.position);
        character.center = new Vector3(capsuleCenter.x, character.height / 2 + character.skinWidth, capsuleCenter.z);
    }

    private bool CheckIfGrounded()
    {
        // tells us if on ground
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }
}
