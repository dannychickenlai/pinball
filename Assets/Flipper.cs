using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(HingeJoint))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MeshCollider))]

public class Flipper : MonoBehaviour
{
    [SerializeField] float startPos = 0;
    [SerializeField] float endPos = 50;
    [SerializeField] float power = 10;
    [SerializeField] float damper = 0;

    HingeJoint joint;
    JointSpring spring;
    JointLimits limits;

    public enum Sides
    {
        LEFT,
        RIGHT
    }
    public Sides side;

    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint>();
        joint.useSpring = true;
        spring = new JointSpring();
        spring.spring = power;
        spring.damper = damper;
        
        joint.useLimits = true;
        limits = new JointLimits();
        limits.min = startPos;
        limits.max = endPos * direction;
        joint.limits = limits;
    }

    // Update is called once per frame
    void Update()
    {
        if(side == Sides.LEFT) {
            if(Input.GetKey(KeyCode.LeftArrow)) {
                spring.targetPosition = endPos * direction;
            }
            else
            {
                spring.targetPosition = startPos;
            }
        }
        if(side == Sides.RIGHT) {
            if(Input.GetKey(KeyCode.RightArrow)) {
                spring.targetPosition = endPos * direction;
            }
            else
            {
                spring.targetPosition = startPos;
            }
        }

        joint.spring = spring;
    }
}
