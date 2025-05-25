using UnityEngine;
using VContainer;

namespace World
{
    public class MainScene : MonoBehaviour
    {
        [Inject]
        CharacterManager characterManager;

        void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                Character c = characterManager.GenerateRandomCharacter();
                characterManager.AddCharacter(c);
                Debug.Log(c.LastName);
            }
        }
    }
}
