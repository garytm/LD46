﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemies {
    public class SimpleEnemy : EnemyBase {
        Vector2 movement;
        public Transform player;
        Rigidbody2D enemyRigidBody;

        void Start() {
            enemyRigidBody = this.GetComponent<Rigidbody2D>();
        }

        void Update() {
            Vector2 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }

        void Move(Vector2 direction) {
            enemyRigidBody.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }
    }
}