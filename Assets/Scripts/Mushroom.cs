using System.Collections;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] private int _debafChance;//(от 0-100) Шанс выпадения плохого эффекта при съедании гриба
        [SerializeField] private float _debafDuration;//Длительность переворота экранааа
        private Camera _camera;//Камера:0
        private void Awake() => _camera = Camera.main;//Хз какой-то там камераа?
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.GetComponent<PlayerMovement>())
            {
                int randomDigit = Random.Range(0, 101);
                if (randomDigit < _debafChance) StartCoroutine(FlipPlayersScreenView());
                //Гриб не должен уничтожаться сразу. Прост я хз, корутина не продолжается и поворот экрана не сработает
                transform.position = new Vector2(transform.position.x, transform.position.y + 1000);
                Destroy(gameObject,_debafDuration + 1);
            }
        }
        IEnumerator FlipPlayersScreenView()
        {
            _camera.orthographicSize *= -1;
            yield return new WaitForSeconds(_debafDuration);
            _camera.orthographicSize *= -1;
        }
}
