using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Movimiento : MonoBehaviour
{
    public GameObject modelo;
    public ObserverBehaviour[] ImageTargets;
    public int currentTarget;
    public float speed = 1.0f;
    private bool isMoving=false;

    public void MoveToNextMarker()
    {
        if (!isMoving)
        {
           StartCoroutine(MoveModel());
        }
    }

    private IEnumerator MoveModel()
    {
        isMoving=true;
        ObserverBehaviour target = GetNextDetectedTarget();
        if (target == null)
        {
            isMoving = false;
            yield break;
        }
        Vector3 startPosition = modelo.transform.position;
        Vector3 endPosition = target.transform.position;

        float journey = 0;

        while (journey <= 1f)
        {
            journey += Time.deltaTime*speed;
            modelo.transform.position = Vector3.Lerp(startPosition, endPosition, journey);
            yield return null;
        }
        currentTarget= (currentTarget+1)%ImageTargets.Length;
        isMoving=false;

    }
    private ObserverBehaviour GetNextDetectedTarget()
    {
        foreach (ObserverBehaviour target in ImageTargets)
        {
            if (target != null && (target.TargetStatus.Status == Status.TRACKED || target.TargetStatus.Status == Status.EXTENDED_TRACKED))
            {
                return target;
            }
        }
        return null;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
