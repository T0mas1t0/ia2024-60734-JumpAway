using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDynamicPlatform : MonoBehaviour
{

    private Vector3 endPosition = new Vector3 (5, -2, 0);
    private Vector3 startPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;

    [SerializeField]
    private AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;
        
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0, 1, percentageComplete));
        
    }
}
