using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{

    [SerializeField] Transform[] TreePos;
    public GameObject Tree;
    [SerializeField] int TreeCount; 
    int posIndex;
    Vector3 Size; 
    // Start is called before the first frame update

    private void Start()
    {
        TreeCount = Random.Range(0, TreePos.Length - 1); 
        for (int i = 0; i <= TreeCount; i++)
        {
            Size = new Vector3(Random.Range(2, 9), Random.Range(2, 9), Random.Range(2, 9));
            posIndex = Random.Range(0, 2);
     
            var tree = Instantiate(Tree, TreePos[posIndex].localPosition, TreePos[posIndex].localRotation);
            tree.transform.localScale = Size; 
        }

    }

}
