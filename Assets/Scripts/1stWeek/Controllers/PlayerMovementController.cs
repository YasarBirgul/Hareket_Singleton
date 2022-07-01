using UnityEngine;
public class PlayerMovementController : MonoBehaviour
{
   #region Self Variables

   #region Serialized Variables

   [SerializeField] private int speed=5;
   
   #endregion

   #region Private Variables

   private Rigidbody _rigidbody = new Rigidbody();
   private Vector2 _inputValues;
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

   #region Event Subsription
   private void OnEnable()
   {
      SubscribeEvents();
   }
   void SubscribeEvents()
   {
      EventManager.Instance.onInputDragged += OnUpdateInputParams;
   }
   void UnSubscribeEvents()
   {
      EventManager.Instance.onInputDragged -= OnUpdateInputParams;
   } 
   private void OnDisable()
   {
      UnSubscribeEvents();
   }

   #endregion

   private void OnUpdateInputParams(InputParams inputParams)
   {
      _inputValues = new Vector2(inputParams.XValue, inputParams.YValue);
   }
   
   // private Vector2 GetInputData() => new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
   
   //// WORKS IN THE SAME WAY ////
   // 
   // private Vector2 GetInputData() {
   // return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
   // }
   /// 

   private void FixedUpdate()
   {
     MovePlayer();
   }

   private void MovePlayer()
   {
      _rigidbody.velocity = new Vector3(_inputValues.x * speed, _rigidbody.velocity.y,_inputValues.y*speed);
      // transform.Translate(new Vector3(_inputValues.x*speed*Time.deltaTime,0,_inputValues.y*speed*Time.deltaTime));
      // _rigidbody.AddForce(new Vector3(_inputValues.x * speed*Time.fixedDeltaTime, 0, _inputValues.y * speed*Time.fixedDeltaTime),ForceMode.Impulse);
      // _rigidbody.AddForce(new Vector3(_inputValues.x * speed*Time.fixedDeltaTime, 0, _inputValues.y * speed*Time.fixedDeltaTime),ForceMode.VelocityChange);
      // transform.position += new Vector3(_inputValues.x , 0, _inputValues.y)*speed*Time.deltaTime;
      // transform.position = Vector3.MoveTowards(transform.position,new Vector3(_inputValues.x, 1,_inputValues.y),10);
      // _rigidbody.velocity += Vector3.Lerp(_rigidbody.position, new Vector3(_inputValues.x * speed*Time.fixedDeltaTime, _rigidbody.velocity.y, _inputValues.y * speed*Time.fixedDeltaTime),1000);
   }
}
