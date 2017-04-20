﻿using System;
using UnityEngine;

namespace GameplayFramework
{
    public class PlayerInput : IDisposable
    {
        public PlayerInput()
        {
            Debug.Log("Init input.");
            TickEnabled = true;
        }



        private bool _tickEnabled = false;
        public bool TickEnabled
        {
            get
            {
                return _tickEnabled;
            }
            set
            {
                if(value == _tickEnabled)
                    return;

                if(value)
                {
                    World.TickPlayerInput += Tick;
                }
                else
                {
                    World.TickPlayerInput -= Tick;
                }

                _tickEnabled = value;
            }
        }



        protected virtual void Tick(TickArgs e)
        {
        }



        public virtual void Dispose()
        {
            TickEnabled = false;
        }
    }
}