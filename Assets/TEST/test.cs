
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test : MonoBehaviour
{
    public List<Transform> Tails;
    private int tailGenerationCountNumber;
    [Range(0, 2)]
    public float BonesDistance;
    public GameObject bone;
    public GameObject Boneprefab;
    private Transform _transform;
    [Range(0, 14)]
    public float Speed;
    private int myHealthsPoint;
    [SerializeField]
    public Text HPs;
    public int hunger;
    
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        MoveSnake(_transform.position + _transform.forward * Speed*Time.deltaTime);
        float angel = Input.GetAxis("Horizontal")/2;
        _transform.Rotate(0, angel, 0);
    }

    

    private void MoveSnake(Vector3 newPosition)
    {

        float sqrDistance = BonesDistance * BonesDistance;
        Vector3 previousPosition = _transform.position;

        foreach (var bone in Tails)
        {
            if (bone != null)
            {
                if ((bone.position - previousPosition).sqrMagnitude > sqrDistance)
                {
                    var temp = bone.position;
                    bone.position = previousPosition;
                    previousPosition = temp;
                }
                else
                {
                    break;
                }
            }
           
        }
        _transform.position = newPosition;
    }
    private void OnCollisionEnter(Collision collision)
    {
        foodpeace peace = new foodpeace();

        peace = collision.transform.GetComponent<foodpeace>();
        int hp = peace.Hp;
        bool type = peace.Type;

        Debug.Log(hp);

        if (type == false)
        {
            Destroy(collision.gameObject);
            tailGenerationCountNumber = hp;

            for (int i = 0; i < tailGenerationCountNumber; i++)
            {
                var tailPiece = Tails[0];
                Destroy(tailPiece.gameObject);
                Tails.RemoveAt(0);
                
            }
            
            myHealthsPoint = Tails.Count;
            HPs.text = myHealthsPoint.ToString();
        }
        if (type == true)
        {
            Destroy(collision.gameObject);

            tailGenerationCountNumber = hp;

            for (int i = 0; i < tailGenerationCountNumber; i++)
            {
                var bone = Instantiate(Boneprefab);
                hunger++;
                bone.transform.gameObject.GetComponent<idScript>().id += hunger;
                Debug.Log(bone.transform.gameObject.GetComponent<idScript>().id + "Тест Индекса"); 
                Tails.Add(bone.transform);
            }

            myHealthsPoint = Tails.Count;
            HPs.text = myHealthsPoint.ToString();
        }



    }
}
