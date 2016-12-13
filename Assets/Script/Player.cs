using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour
{
    public float duration;

    public NoteBook notebook;
    public GUIManager GUIMgr;

    private Animator anim;

    private bool move;
    private Vector3 nextPos;

    private List<Vector2> path;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        move = false;

        if (!ConstantObject.getInit())
        {
            ConstantObject.initilisation();
            Debug.Log("Initialisation des objets constants");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check if the flag for movement is true and the current gameobject position is not same as the clicked / tapped position
        if (move && !Mathf.Approximately(gameObject.transform.position.magnitude, nextPos.magnitude)) //&& !(V3Equal(transform.position, endPoint))){
        {
            //move the gameobject to the desired position
            //             transform.Rotate(nextPos);
            //             Vector3 rotate = ;
            //             transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0));

            Vector3 relativePos = nextPos - transform.position;
            relativePos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(relativePos);

            transform.rotation = rotation;

            anim.SetBool("IsWalking", true);
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, nextPos, 1 / (duration * (Vector3.Distance(gameObject.transform.position, nextPos))));
        }
        //set the movement indicator flag to false if the endPoint and current gameobject position are equal
        else if (move && Mathf.Approximately(gameObject.transform.position.magnitude, nextPos.magnitude))
        {
            move = false;
            anim.SetBool("IsWalking", false);

        }
    }

    public void showBook()
    {
        GUIMgr.showUI(EnumUI.NoteBook);
        notebook.showPage();
        enabled = false;
    }

    public void hideBook()
    {
        notebook.ResetPage();
        GUIMgr.hideUI();
        enabled = true;
    }

    public void GoToPosition(Vector3 pos)
    {
        nextPos = pos;
        nextPos.z = 0;

        if(enabled)
            move = true;
    }
}
