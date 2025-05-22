using UnityEngine;

namespace World
{
    public class CharacterControler : MonoBehaviour
    {
        Character character;
        public string TestName;

        void Start()
        {
            character = Character.GenerateRandomCharacter();
            TestName = character.LastName;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
