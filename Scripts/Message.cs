using UnityEngine;

namespace Namespace.UnityPackageExample
{
    public class Message : MonoBehaviour
    {
        public string name;
        
        public void Start()
        {
            Debug.Log("Hello " + name + "!");
        }

    }

}
