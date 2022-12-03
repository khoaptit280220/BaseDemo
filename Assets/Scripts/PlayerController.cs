using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MeshRenderer head;
    public float speed = 10.0f;

    public float speedRotate = 10;

    private float horizontalInput;

    private float verticalInput;
    

    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput* (Time.deltaTime * speed));
        transform.Rotate(Vector3.up*horizontalInput*Time.deltaTime*speedRotate);
    }

    public void SetColor(Color _color)
    {
        if (meshRenderer.material.color == _color)
        {
            Died();
        }
        else
        {
            meshRenderer.material.color = _color;
            head.material.color = _color;
        }
        
    }

    private void Died()
    {
        GameManager.Instance.OnLoseGame();
    }
}
