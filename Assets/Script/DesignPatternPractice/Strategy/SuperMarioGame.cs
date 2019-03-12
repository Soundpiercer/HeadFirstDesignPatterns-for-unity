// [HEAD FIRST DESIGN PATTERNS - 01. STRATEGY PATTERN]
// 
// Super Mario Game
// Author : Soundpiercer
// soundpiercer@gmail.com
//
// 권장하는 보는 순서
// 1. SuperMarioGame.cs 선언부까지 
// 2. 각 Behaviour.cs (인터페이스 - 구현 클래스 순서로)
// 3. SuperMarioGame.cs 나머지
// 4. 유니티 씬파일
// 5. 아래의 팁
//
// 
// ※ Tip :
// Init 및 마리오 모드 변화 시 지금은 일일히 새로운 동작을 지정해 주고 있지만,
// 마리오 역시 별도 클래스로 빼서 캡슐화하는 것이 가능합니다.
// 
// ex)
// (선언부) protected Mario _mario;
// (Init 메서드) _mario = new MarioFlower(); --> MarioFlower는 Mario의 서브클래스

using UnityEngine;

namespace headfirst.strategy
{
    public class SuperMarioGame : MonoBehaviour
    {
        protected IMarioJumpBehaviour _jumpBehaviour;
        protected IMarioFireBehaviour _fireBehaviour;
        protected IMarioRollBehaviour _rollBehaviour;
        protected IMarioCrouchBehaviour _crouchBehaviour;

        private void Start()
        {
            Debug.Log("<color=#00FF00>########### Super Mario Bros. ###########</color>");
            Debug.LogWarning("Your Mario is small mode");

            _jumpBehaviour = new MarioJumpBehaviourSmall();
            _fireBehaviour = new MarioFireBehaviourSmall();
            _rollBehaviour = new MarioRollBehaviourSmall();
            _crouchBehaviour = new MarioCrouchBehaviourSmall();
        }

        #region Button Logics
        public void SmallMode()
        {
            Debug.LogWarning("Your Mario has changed to Small Mode!");

            _jumpBehaviour = new MarioJumpBehaviourSmall();
            _fireBehaviour = new MarioFireBehaviourSmall();
            _rollBehaviour = new MarioRollBehaviourSmall();
            _crouchBehaviour = new MarioCrouchBehaviourSmall();
        }

        public void BigMode()
        {
            Debug.LogWarning("Your Mario has changed to Big Mode!");

            _jumpBehaviour = new MarioJumpBehaviourBig();
            _fireBehaviour = new MarioFireBehaviourBig();
            _rollBehaviour = new MarioRollBehaviourBig();
            _crouchBehaviour = new MarioCrouchBehaviourBig();
        }

        public void FlowerMode()
        {
            Debug.LogWarning("Your Mario has changed to Flower Mode!");

            _jumpBehaviour = new MarioJumpBehaviourFlower();
            _fireBehaviour = new MarioFireBehaviourFlower();
            _rollBehaviour = new MarioRollBehaviourFlower();
            _crouchBehaviour = new MarioCrouchBehaviourFlower();
        }

        public void SquarrelMode()
        {
            Debug.LogWarning("Your Mario has changed to Squarrel Mode!");

            _jumpBehaviour = new MarioJumpBehaviourSquarrel();
            _fireBehaviour = new MarioFireBehaviourSquarrel();
            _rollBehaviour = new MarioRollBehaviourSquarrel();
            _crouchBehaviour = new MarioCrouchBehaviourSquarrel();
        }

        public void Jump()
        {
            _jumpBehaviour.Jump();
        }

        public void Fire()
        {
            _fireBehaviour.Fire();
        }

        public void Roll()
        {
            _rollBehaviour.Roll();
        }

        public void Crouch()
        {
            _crouchBehaviour.Crouch();
        }
        #endregion
    }
}