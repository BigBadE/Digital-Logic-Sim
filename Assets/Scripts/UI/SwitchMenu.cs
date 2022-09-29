using UnityEngine;

namespace UI
{
    public class SwitchMenu : MonoBehaviour
    {
        private Transform _transform;

        void Awake()
        {
            _transform = GetComponent<Transform>();
        }
        
        public void Activate(GameObject target)
        {
            if (target.activeSelf)
            {
                _transform.Translate(0, -target.GetComponent<Transform>().localScale.y, 0);
                target.SetActive(false);
            }
            else
            {
                _transform.Translate(0, target.GetComponent<Transform>().localScale.y, 0);
                target.SetActive(true);
            }
        }
    }
}