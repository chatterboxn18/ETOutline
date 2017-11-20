using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ETOutline
{
    public class MainControl : MonoBehaviour
    {
        public Animator _animator;

        //////Scene Events///////



        //////Button Events////////
        public void BtnEvt_GoToSelection()
        {
            NumGameState = GameState.Selection;
        }

        public void BtnEvt_GoToHome()
        {
            NumGameState = GameState.Home;
        }

        private GameState NumGameState { get { return (GameState)_animator.GetInteger("NumGameState"); } set { _animator.SetInteger("NumGameState", (int)value); } }

    }
}
