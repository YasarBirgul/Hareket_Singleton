using UnityEngine;

namespace Controllers
{
    public class PlayerMovementController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private int speed = 5;
        #endregion
       
        #region Private Variables
        
        private Rigidbody _rigidbody = new Rigidbody();
        private Vector2 _inputValuesXY = new Vector2();
        #endregion
        
        #endregion

        private void Awake()
        {
            GetReferences();
        }

        private void GetReferences()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void SubscribeEvents()
        {
            EventManager.Instance.onInputDrag += OnUpdateInputParamaters;
        }
        
        private void UnSubscribeEvents()
        {
            EventManager.Instance.onInputDrag -= OnUpdateInputParamaters;
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }
        private void OnUpdateInputParamaters(InputParamaters inputParamaters)
        {
            _inputValuesXY = new Vector2(inputParamaters.XvalueP, inputParamaters.YvalueP);
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.Translate(new Vector3(_inputValuesXY.x,0,_inputValuesXY.y)*speed*Time.deltaTime);
        }

        private void OnDestroy()
        {
            UnSubscribeEvents();
        }
    }
}

