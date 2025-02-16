using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Allows movement for the player
        if(Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector2.down * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector2.right * _speed * Time.deltaTime);
        }

        // allows the ability to plant seeds/plants
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }

    public void PlantSeed ()
    {
        if(_numSeedsPlanted < _numSeeds)
        {
            Instantiate(_plantPrefab, new Vector2(_playerTransform.localPosition.x, _playerTransform.localPosition.y), Quaternion.identity);
            _numSeedsPlanted++;
            _numSeedsLeft--;
        }
    }
}
