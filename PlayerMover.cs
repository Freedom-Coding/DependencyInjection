using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjection
{
    public class PlayerMover
    {
        private Rigidbody2D rb;
        private IPlayerInput playerInput;

        public PlayerMover(IPlayerInput _playerInput, Rigidbody2D _rb)
        {
            playerInput = _playerInput;
            rb = _rb;
        }

        public void Move()
        {
            rb.velocity = playerInput.GetMoveVector();
        }
    }
}